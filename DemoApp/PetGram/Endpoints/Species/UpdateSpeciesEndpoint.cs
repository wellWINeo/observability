using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PetGram.Endpoints.Extensions;
using PetGram.Endpoints.Mappers;
using PetGram.Core.Dto;
using PetGram.Filters;
using PetGram.Services;

namespace PetGram.Endpoints.Species;

public static class UpdateSpeciesEndpoint
{
    public static RouteGroupBuilder Map(RouteGroupBuilder group)
    {
        group
            .MapPut("/{id:int}", Execute)
            .AddEndpointFilter<AdminTokenFilter>();

        return group;
    }

    public static Task<Ok> Execute(
        [FromRoute] int id,
        [FromBody] MutateSpeciesDto dto,
        [FromServices] SpeciesService service
    ) => service
        .Update(dto.ToModel(id))
        .AsOk();

}