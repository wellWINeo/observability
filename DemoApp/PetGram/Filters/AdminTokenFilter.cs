using Microsoft.Extensions.Options;
using PetGram.Core.Exceptions;
using PetGram.Core.Options;

namespace PetGram.Filters;

public class AdminTokenFilter(IOptions<AdminOptions> adminOptions) : IEndpointFilter
{
    private const string ADMIN_TOKEN_HEADER = "X-ADMIN-TOKEN";
    private string AdminToken => adminOptions.Value.Token;
    
    public ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        var token = GetToken(context);

        if (token == null || token != AdminToken)
        {
            throw new AdminRightsRequiredException();
        }

        return next(context);
    }

    private string? GetToken(EndpointFilterInvocationContext context)
        => context.HttpContext.Request.Headers
                .TryGetValue(ADMIN_TOKEN_HEADER, out var headerValue) switch
        {
            true => (string) headerValue!,
            false => null,
        };
}