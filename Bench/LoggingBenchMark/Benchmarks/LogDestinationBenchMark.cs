using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Microsoft.Extensions.Logging;
using NReco.Logging.File;

namespace LoggingBenchmark.Benchmarks;

[SimpleJob(RuntimeMoniker.Net80)]
public class LogDestinationBenchMark
{
    private ILoggerFactory _consoleLoggerFactory;
    private ILoggerFactory _fileLoggerFactory;

    private ILogger _consoleLogger;
    private ILogger _fileLogger;
    
    [GlobalSetup]
    public void Setup()
    {
        _consoleLoggerFactory = LoggerFactory.Create(logging => logging.AddConsole());
        _fileLoggerFactory = LoggerFactory.Create(logging => logging.AddFile(@"$HOME/Tmp/app.log", append: true));

        _consoleLogger = _consoleLoggerFactory.CreateLogger<LogDestinationBenchMark>();
        _fileLogger = _fileLoggerFactory.CreateLogger<LogDestinationBenchMark>();
    }

    [Benchmark]
    public void Console()
    {
        var number = 5;
        
        _consoleLogger.LogInformation(1_000, "Log with {number}", number);
    }
    
    [Benchmark]
    public void File()
    {
        var number = 5;
        
        _fileLogger.LogInformation(1_000, "Log with {number}", number);
    }


    [GlobalCleanup]
    public void Cleanup()
    {
        _consoleLoggerFactory.Dispose();
        _fileLoggerFactory.Dispose();
    }
}