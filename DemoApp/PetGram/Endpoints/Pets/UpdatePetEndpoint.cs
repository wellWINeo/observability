using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PetGram.Endpoints.Mappers;
using PetGram.Core.Dto;
using PetGram.Services;

namespace PetGram.Endpoints.Pets;

public static class UpdatePetEndpoint
{
    public static RouteGroupBuilder Map(this RouteGroupBuilder group)
    {
        group.MapPut("/{id:int}", Execute);
        
        return group;
    }
    
    public static async Task<Results<Ok, ProblemHttpResult>> Execute(
        [FromRoute] int id,
        [FromBody] MutatePetDto dto,
        [FromServices] PetsService petsService
    ) => await petsService.UpdatePet(dto.ToModel(id)) switch
    {
        { } => TypedResults.Ok(),
        _ => TypedResults.Problem(),
    };
}
