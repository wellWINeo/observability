using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PetGram.Endpoints.Extensions;
using PetGram.Endpoints.Mappers;
using PetGram.Core.Dto;
using PetGram.Services;

namespace PetGram.Endpoints.Pets;

public static class GetPetsByNamesEndpoint
{
    public static RouteGroupBuilder Map(this RouteGroupBuilder group)
    {
        group.MapGet("/", Execute);
        
        return group;
    }
    
    public static async Task<Ok<ICollection<PetDto>>> Execute(
        [FromQuery] string name,
        [FromServices] PetsService petsService
    ) => (await petsService.GetPetsByName(name))
        .ToDtos()
        .AsOk();
}
