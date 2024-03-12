using PetGram.Core.Logging;

namespace PetGram.Services.Caching;

internal static partial class CacheServiceLogger
{
    [LoggerMessage(
        EventId = InternalEventId.CacheValueMissed,
        Level = LogLevel.Debug,
        Message = "Missed cache value for key {key}"
    )]
    internal static partial void LogCacheMiss(this ILogger logger, object key);

    [LoggerMessage(
        EventId = InternalEventId.CacheRetrievedNullActualValue,
        Level = LogLevel.Debug,
        Message = "Cache retrieved null actual value for key {key}"
    )]
    internal static partial void LogCacheNullActualValue(this ILogger logger, object key);

    [LoggerMessage(
        EventId = InternalEventId.CacheReturnedActualValue,
        Level = LogLevel.Debug,
        Message = "Cache returned actual value {value} for key {key}"
    )]
    internal static partial void LogActualValue(this ILogger logger, object value, object key);

    [LoggerMessage(
        EventId = InternalEventId.CacheValueReturned,
        Level = LogLevel.Debug,
        Message = "Return cached value {value} for key {key}"
    )]
    internal static partial void LogReturnCachedValue(this ILogger logger, object value, object key);
}