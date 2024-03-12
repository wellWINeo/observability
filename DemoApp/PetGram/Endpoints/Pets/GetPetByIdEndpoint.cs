using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PetGram.Endpoints.Mappers;
using PetGram.Core.Dto;
using PetGram.Core.Models;
using PetGram.Services;

namespace PetGram.Endpoints.Pets;

public static class GetPetByIdEndpoint
{
    public static RouteGroupBuilder Map(this RouteGroupBuilder group)
    {
        group.MapGet("/{id:int}", Execute);
        
        return group;
    }
    
    public static async Task<Results<Ok<PetDto>, NotFound>> Execute(
        [FromRoute] int id,
        [FromServices] PetsService petsService
    ) => await petsService.GetPetById(id) switch
    {
        Pet pet => TypedResults.Ok(pet.ToDto()),
        null => TypedResults.NotFound(),
    };
}
