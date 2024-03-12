using PetGram.Core.Models.Internal;

namespace PetGram.Core.Models;

public class Species : IEntity
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    public ICollection<Breed> Breeds { get; set; } = [];
}
