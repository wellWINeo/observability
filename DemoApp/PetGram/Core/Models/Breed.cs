using PetGram.Core.Models.Internal;

namespace PetGram.Core.Models;

public class Breed : IEntity
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required string OriginCountry { get; set; }
    public required BreedSize Size { get; set; }
    public required int LifeSpan { get; set; }
    public required string TemperamentDescription { get; set; }
    public ICollection<HealthIssue> HealthIssues { get; set; } = [];
    public Species? Species { get; set; }
    public int SpeciesId { get; set; }

    public ICollection<Pet> Pets { get; set; } = [];
}
