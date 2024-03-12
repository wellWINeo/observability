using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PetGram.Endpoints.Extensions;
using PetGram.Endpoints.Mappers;
using PetGram.Core.Dto;
using PetGram.Services;

namespace PetGram.Endpoints.Breeds;

public static class GetBreedsEndpoint
{
    public static RouteGroupBuilder Map(this RouteGroupBuilder group)
    {
        group.MapGet("/", Execute);
        
        return group;
    }
    
    public static async Task<Ok<ICollection<BreedDto>>> Execute(
        [FromServices] BreedsService breedsService
    ) => (await breedsService.GetAll())
        .ToDtos()
        .AsOk();
}
