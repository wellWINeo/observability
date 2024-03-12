using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PetGram.Endpoints.Mappers;
using PetGram.Core.Dto;
using PetGram.Services;

namespace PetGram.Endpoints.Breeds;

public static class CreateBreedEndpoint
{
    public static RouteGroupBuilder Map(this RouteGroupBuilder group)
    {
        group.MapPost("/", Execute);
        
        return group;
    }

    public static async Task<Ok<IdDto>> Execute(
        [FromBody] MutateBreedDto dto,
        [FromServices] BreedsService service
    )
    {
        var breed = dto.ToModel();

        var id = await service.Create(breed);

        return TypedResults.Ok(new IdDto(id));
    }
}