using PetGram.Core.Models;

namespace PetGram.Core.Dto;

public class MutateBreedDto
{
    public required string Name { get; init; }
    public string? Description { get; init; }
    public required string Country { get; init; }
    public required BreedSize Size { get; init; }
    public required int LifeSpan { get; init; }
    public required string TemperamentDescription { get; init; }
    public required ICollection<int> HealthIssueIds { get; init; } = [];
    public required int SpeciesId { get; init; }
}