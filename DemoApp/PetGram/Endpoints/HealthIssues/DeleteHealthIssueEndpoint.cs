using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PetGram.Endpoints.Extensions;
using PetGram.Filters;
using PetGram.Services;

namespace PetGram.Endpoints.HealthIssues;

public static class DeleteHealthIssueEndpoint
{
    public static RouteGroupBuilder Map(RouteGroupBuilder group)
    {
        group
            .MapDelete("/{id:int}", Execute)
            .AddEndpointFilter<AdminTokenFilter>();

        return group;
    }

    public static Task<Ok> Execute(
        [FromRoute] int id,
        [FromServices] HealthIssuesService service
    ) => service
        .Delete(id)
        .AsOk();
}