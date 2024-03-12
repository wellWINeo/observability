using PetGram.Core.Models;

namespace PetGram.Core.Dto;

public class BreedDto
{
    public required int Id { get; init; }
    public required string Name { get; init; }
    public required string? Description { get; init; }
    public required string OriginCountry { get; init; }
    public required BreedSize Size { get; init; }
    public required int LifeSpan { get; init; }
    public required string TemperamentDescription { get; init; }
    public required ICollection<HealthIssueDto> HealthIssues { get; init; }
}