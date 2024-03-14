using Microsoft.Extensions.Logging;

namespace LoggingBenchmark;

internal static partial class SourceGeneratedLog
{
    [LoggerMessage(Level = LogLevel.Debug, Message = "Number {number}")]
    public static partial void LogDebugIteration(this ILogger logger, int number);
    
    [LoggerMessage(Level = LogLevel.Trace, Message = "Number {number}")]
    public static partial void LogTraceIteration(this ILogger logger, int number);
}