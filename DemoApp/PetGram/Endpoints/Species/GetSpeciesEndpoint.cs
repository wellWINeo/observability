using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PetGram.Endpoints.Extensions;
using PetGram.Core.Dto;
using PetGram.Endpoints.Mappers;
using PetGram.Services;

namespace PetGram.Endpoints.Species;

public static class GetSpeciesEndpoint
{
    public static RouteGroupBuilder Map(RouteGroupBuilder group)
    {
        group.MapGet("/", Execute);

        return group;
    }

    public static Task<Ok<ICollection<SpeciesDto>>> Execute([FromServices] SpeciesService service)
        => service
            .GetAll()
            .Pipe(SpeciesMappings.ToDtos)
            .AsOk();
}