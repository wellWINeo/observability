using PetGram.Core.Dto;
using PetGram.Core.Models;

namespace PetGram.Endpoints.Mappers;

internal static class HealthIssueMappings
{
    public static HealthIssue ToModel(this MutateHealthIssueDto dto) => new()
    {
        Id = 0,
        Breeds = [],
        IsCritical = dto.IsCritical,
        Suggestion = dto.Suggestion,
        Title = dto.Title,
    };
    
    public static HealthIssueDto ToDto(this HealthIssue healthIssue) => new()
    {
        Id = healthIssue.Id,
        Title = healthIssue.Title,
        Suggestion = healthIssue.Suggestion,
        IsCritical = healthIssue.IsCritical
    };

    public static ICollection<HealthIssueDto> ToDtos(this ICollection<HealthIssue> healthIssues)
        => healthIssues.Select(ToDto).ToList();
}