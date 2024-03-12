using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PetGram.Endpoints.Extensions;
using PetGram.Filters;
using PetGram.Services;

namespace PetGram.Endpoints.Species;

public static class DeleteSpeciesEndpoint
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
        [FromServices] SpeciesService service
    ) => service
        .Delete(id)
        .Pipe(TypedResults.Ok);

}