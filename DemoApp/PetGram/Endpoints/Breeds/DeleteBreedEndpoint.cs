using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PetGram.Services;

namespace PetGram.Endpoints.Breeds;

public static class DeleteBreedEndpoint
{
    public static RouteGroupBuilder Map(this RouteGroupBuilder group)
    {
        group.MapDelete("/{id:int}", Execute);
        
        return group;
    }

    public static async Task<Results<Ok, NotFound>> Execute(
        [FromRoute] int id,
        [FromServices] BreedsService service
    )
    {
        await service.Delete(id);

        return TypedResults.Ok();
    }
}