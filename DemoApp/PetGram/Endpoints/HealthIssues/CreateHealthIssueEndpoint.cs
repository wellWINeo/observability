using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PetGram.Endpoints.Extensions;
using PetGram.Endpoints.Mappers;
using PetGram.Core.Dto;
using PetGram.Filters;
using PetGram.Services;

namespace PetGram.Endpoints.HealthIssues;

public static class CreateHealthIssueEndpoint
{
    public static RouteGroupBuilder Map(RouteGroupBuilder group)
    {
        group
            .MapPost("/", Execute)
            .AddEndpointFilter<AdminTokenFilter>();

        return group;
    }

    public static Task<Ok<IdDto>> Execute(
        [FromBody] MutateHealthIssueDto dto,
        [FromServices] HealthIssuesService service
    ) => service.Create(dto.ToModel())
        .Pipe(id => new IdDto(id))
        .AsOk();
}