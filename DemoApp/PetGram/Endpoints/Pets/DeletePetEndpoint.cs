using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PetGram.Services;

namespace PetGram.Endpoints.Pets;

public static class DeletePetEndpoint
{
    public static RouteGroupBuilder Map(this RouteGroupBuilder group)
    {
        group.MapDelete("/{id:int}", Execute);
        
        return group;
    }
    
    public static async Task<Results<Ok, ProblemHttpResult>> Execute(
        [FromRoute] int id,
        [FromServices] PetsService petsService
    )
    {
        await petsService.DeletePet(id);
        return TypedResults.Ok();
    }
}
