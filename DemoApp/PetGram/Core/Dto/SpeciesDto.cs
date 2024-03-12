namespace PetGram.Core.Dto;

public class SpeciesDto
{
    public required int Id { get; init; }
    public required string Name { get; init; }
    public string? Description { get; init; }
}