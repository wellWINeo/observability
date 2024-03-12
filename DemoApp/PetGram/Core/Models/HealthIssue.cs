using PetGram.Core.Models.Internal;

namespace PetGram.Core.Models;

public class HealthIssue : IEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Suggestion { get; set; } = string.Empty;
    public bool IsCritical { get; set; }

    public ICollection<Breed> Breeds { get; set; } = [];
}
