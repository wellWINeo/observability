using PetGram.Core.Models.Internal;

namespace PetGram.Core.Models;

public class Pet : IEntity
{
    public required int Id { get; set; }
    public required string NickName { get; set; }
    public required int Age { get; set; }
    public required Gender Gender { get; set; }

    public Breed? Breed { get; set; }
    public int BreedId { get; set; }
}
