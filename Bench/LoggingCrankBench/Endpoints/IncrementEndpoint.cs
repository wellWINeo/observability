using LoggingCrankBench.Core;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LoggingCrankBench.Endpoints;

public class IncrementEndpoint
{
    public static Ok<IncrementResultDto> NoLog([FromRoute] int value) 
        => TypedResults.Ok(new IncrementResultDto(value, ++value));

    public static Ok<IncrementResultDto> StandardLog(
        [FromServices] ILogger<IncrementEndpoint> logger,
        [FromRoute] int value)
    {
        logger.LogInformation("Incrementing value {value}", value);
        
        return TypedResults.Ok(new IncrementResultDto(value, ++value));
    }
    
    public static Ok<IncrementResultDto> SourceGenLog(
        [FromServices] ILogger<IncrementEndpoint> logger,
        [FromRoute] int value)
    {
        logger.LogIncrement(value);
        
        return TypedResults.Ok(new IncrementResultDto(value, ++value));
    }
    
    public static Ok<IncrementResultDto> DefinedLog(
        [FromServices] ILogger<IncrementEndpoint> logger,
        [FromRoute] int value)
    {
        logger.LogDefineIncrement(value);
        
        return TypedResults.Ok(new IncrementResultDto(value, ++value));
    }
    
    public static Ok<IncrementResultDto> SuppressLog(
        [FromServices] ILogger<IncrementEndpoint> logger,
        [FromRoute] int value)
    {
        logger.LogDebug("Incrementing value {value}", value);
        
        return TypedResults.Ok(new IncrementResultDto(value, ++value));
    }
    
}

internal static partial class IncrementEndpointLogger
{
    private static readonly Action<ILogger, int, Exception?> s_failedToProcessWorkItem = LoggerMessage.Define<int>(
        LogLevel.Information,
        new EventId(0),
        "Incrementing value {value}"
    );
    
    [LoggerMessage(Level = LogLevel.Information, Message = "Incrementing value {value}")]
    public static partial void LogIncrement(this ILogger logger, int value);

    public static void LogDefineIncrement(this ILogger logger, int value) =>
        s_failedToProcessWorkItem(logger, value, null);
}