using System.Collections.Concurrent;
using System.Timers;
using PetGram.Core.Logging;
using PetGram.Services.Caching;
using Timer = System.Timers.Timer;

namespace PetGram.Services;

public class CacheService<TKey, TValue>
    : IDisposable
    where TKey : IEquatable<TKey>
    where TValue : class
{
    private sealed record CacheWrapper(DateTime ExpiresAt, TValue Value);
    
    private readonly ConcurrentDictionary<TKey, CacheWrapper> _cache = new();
    private readonly TimeSpan _timeToLive = TimeSpan.FromMinutes(10);
    private readonly TimeSpan _purgingInterval = TimeSpan.FromSeconds(10);
    private readonly Timer _timer;
    private readonly ILogger<CacheService<TKey, TValue>> _logger;

    public CacheService(ILogger<CacheService<TKey, TValue>> logger)
    {
        _logger = logger;
        
        _timer = new Timer(_purgingInterval);
        _timer.Elapsed += PurgeExpired;
        _timer.Start();
    }

    private void PurgeExpired(object? sender, ElapsedEventArgs e)
    {
        if (_cache.IsEmpty)
            return;

        var expiredKeys = _cache
            .Where(kv => kv.Value.ExpiresAt < DateTime.UtcNow)
            .Select(kv => kv.Key)
            .ToArray();

        foreach (var key in expiredKeys)
        {
            _cache.Remove(key, out _);
        }
        
        _logger.LogDebug(
            InternalEventId.ExpiredCacheCleared,
            "Cache cleared {keysCount} expired values",
            expiredKeys.Length
        );
    }
    
    public Task<TValue?> Get(TKey key, Func<TKey, Task<TValue?>> retrieve)
        => _cache.GetValueOrDefault(key) switch
        {
            { } cachedValue when cachedValue.ExpiresAt > DateTime.UtcNow => ReturnValue(key, cachedValue),
            null => GetAndSet(key, retrieve),
            _ => GetAndSetIfExpired(key, retrieve),
        };

    private Task<TValue?> ReturnValue(TKey key, CacheWrapper wrapper)
    {
        _logger.LogReturnCachedValue(wrapper.Value, key);

        return Task.FromResult<TValue?>(wrapper.Value);
    }

    private async Task<TValue?> GetAndSet(TKey key, Func<TKey, Task<TValue?>> retrieve)
    {
        _logger.LogCacheMiss(key);
        
        var value = await retrieve(key);

        if (value is null)
        {
            _logger.LogCacheNullActualValue(key);
            return null;
        }

        _cache.TryAdd(key, new CacheWrapper(DateTime.UtcNow + _timeToLive, value));
        
        _logger.LogActualValue(value, key);

        return value;
    }

    private Task<TValue?> GetAndSetIfExpired(TKey key, Func<TKey, Task<TValue?>> retrieve)
    {
        _cache.Remove(key, out _);

        return GetAndSet(key, retrieve);
    }

    public void Dispose() => _timer.Dispose();
}