namespace PetGram.Core.Dto;

public class MutateHealthIssueDto
{
    public required string Title { get; init; }
    public required string Suggestion { get; init; }
    public required bool IsCritical { get; init; }
}