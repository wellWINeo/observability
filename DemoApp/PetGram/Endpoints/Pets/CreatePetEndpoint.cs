using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PetGram.Endpoints.Mappers;
using PetGram.Core.Dto;
using PetGram.Services;

namespace PetGram.Endpoints.Pets;

public static class CreatePetEndpoint
{
    public static RouteGroupBuilder Map(this RouteGroupBuilder group)
    {
        group.MapPost("/", Execute);
        
        return group;
    }
    
    public static async Task<Results<Ok<IdDto>, ProblemHttpResult>> Execute(
        [FromBody] MutatePetDto dto,
        [FromServices] PetsService petsService
    ) => await petsService.CreatePet(dto.ToModel()) switch
    {
        { Id: > 0 } _pet => TypedResults.Ok(new IdDto(_pet.Id)),
        _ => TypedResults.Problem(),
    };
}
