using PetGram.Core.Models;

namespace PetGram.Core.Dto;

public class PetDto
{
    public required int Id { get; init; }
    public required string NickName { get; init; }
    public required int Age { get; init; }
    public required Gender Gender { get; init; }
    public required BreedDto Breed { get; init; }
}