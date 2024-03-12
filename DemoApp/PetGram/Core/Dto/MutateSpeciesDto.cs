namespace PetGram.Core.Dto;

public class MutateSpeciesDto
{
    public required string Name { get; init; }
    public string? Description { get; init; }
}