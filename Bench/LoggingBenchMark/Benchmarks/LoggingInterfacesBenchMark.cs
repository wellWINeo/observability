using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using LoggingBenchmark;
using Microsoft.Extensions.Logging;

[SimpleJob(RuntimeMoniker.Net80)]
public class LoggingInterfacesBenchMark
{
    private readonly ILoggerFactory _loggerFactory;

    public LoggingInterfacesBenchMark(ILoggerFactory loggerFactory)
    {
        _loggerFactory = LoggerFactory.Create(logging => logging.AddConsole());
    }

    public void Dispose() => _loggerFactory.Dispose();

    [Benchmark]
    public int NoLog()
    {
        return 1 + 2;
    }

    [Benchmark]
    public int StandardLog()
    {
        var logger = _loggerFactory.CreateLogger<LoggingInterfacesBenchMark>();

        var number = 1 + 2;
        
        logger.LogDebug("Number #{number}", number);

        return number;
    }

    [Benchmark]
    public int SourceGeneratedLog()
    {
        var logger = _loggerFactory.CreateLogger<LoggingInterfacesBenchMark>();
        
        var number = 1 + 2;

        logger.LogDebugIteration(number);

        return number;
    }

    [Benchmark]
    public int SuppressLog()
    {
        var logger = _loggerFactory.CreateLogger<LoggingInterfacesBenchMark>();

        var number = 1 + 2;

        logger.LogTraceIteration(number);

        return number;
    }
}