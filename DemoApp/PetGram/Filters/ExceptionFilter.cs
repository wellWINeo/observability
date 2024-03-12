using PetGram.Core.Exceptions;
using PetGram.Core.Logging;

namespace PetGram.Filters;

public class ExceptionFilter(ILogger<ExceptionFilter> logger) : IEndpointFilter
{
    public async ValueTask<object?> InvokeAsync(
        EndpointFilterInvocationContext context, 
        EndpointFilterDelegate next)
    {
        try
        {
            return await next(context);
        }
        catch (DomainException e)
        {
            logger.LogInformation(
                eventId: ApplicationEventId.UnprocessibleRequest,
                message: "Cannot process request due to domain exception: {exception}",
                e.Message);

            return TypedResults.Problem(e.GetProblemDetails());
        }
        catch (Exception e)
        {
            logger.LogError(
                eventId: ApplicationEventId.RequestFailed,
                exception: e,
                message: "Request failed"
            );
            
            throw;
        }
    }
}