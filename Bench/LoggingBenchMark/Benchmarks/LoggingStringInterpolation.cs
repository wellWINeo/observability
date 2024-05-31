using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Microsoft.Extensions.Logging;

namespace LoggingBenchmark;

[SimpleJob(RuntimeMoniker.Net80)]
[MemoryDiagnoser]
public class LoggingStringInterpolation
{
    private ILoggerFactory _loggerFactory;
    private ILogger<LoggingStringInterpolation> _logger;

    [GlobalSetup]
    public void Setup()
    {
        _loggerFactory = LoggerFactory.Create(logging =>
        {
            logging.AddFilter(nameof(LoggingStringInterpolation), LogLevel.Information);
        });
        
        _logger = _loggerFactory.CreateLogger<LoggingStringInterpolation>();
    }

    [Benchmark]
    public void Interpolation()
    {
        _logger.LogDebug($"Log from method {nameof(Interpolation)} of {nameof(LoggingStringInterpolation)}");
    }
    
    [Benchmark]
    public void Structural()
    {
        _logger.LogDebug(
            "Log from method {methodName} of {className}", 
            nameof(Structural),
            nameof(LoggingStringInterpolation)
        );
    }

    
    [GlobalCleanup]
    public void Cleanup()
    {
        _loggerFactory.Dispose();
    }
}