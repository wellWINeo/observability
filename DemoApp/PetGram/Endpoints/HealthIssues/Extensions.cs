using PetGram.Filters;

namespace PetGram.Endpoints.HealthIssues;

internal static class Extensions
{
    public static WebApplication MapHealthIssues(this WebApplication app)
    {
        var group = app
            .MapGroup("/api/health-issues")
            .AddEndpointFilter<ExceptionFilter>();

        CreateHealthIssueEndpoint.Map(group);
        DeleteHealthIssueEndpoint.Map(group);
        GetAllHealthIssueEndpoint.Map(group);

        return app;
    }
}