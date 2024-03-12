using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PetGram.Endpoints.Mappers;
using PetGram.Core.Dto;
using PetGram.Services;

namespace PetGram.Endpoints.Breeds;

public static class UpdateBreedEndpoint
{
    public static RouteGroupBuilder Map(this RouteGroupBuilder group)
    {
        group.MapPut("/{id:int}", Execute);
        
        return group;
    }

    public static async Task<Ok> Execute(
        [FromRoute] int id,
        [FromBody] MutateBreedDto dto,
        [FromServices] BreedsService service
    )
    {
        var breed = dto.ToModel();
        breed.Id = id;

        await service.Update(breed);

        return TypedResults.Ok();
    }
}