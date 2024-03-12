using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PetGram.Endpoints.Extensions;
using PetGram.Filters;
using PetGram.Core.Dto;
using PetGram.Endpoints.Mappers;
using PetGram.Services;

namespace PetGram.Endpoints.HealthIssues;

public static class GetAllHealthIssueEndpoint
{
    public static RouteGroupBuilder Map(RouteGroupBuilder group)
    {
        group.MapGet("/", Execute);

        return group;
    }

    public static Task<Ok<ICollection<HealthIssueDto>>> Execute([FromServices] HealthIssuesService service)
        => service
            .GetAll()
            .Pipe(HealthIssueMappings.ToDtos)
            .AsOk();
}