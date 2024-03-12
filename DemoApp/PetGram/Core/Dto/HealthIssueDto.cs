namespace PetGram.Core.Dto;

public class HealthIssueDto
{
    public required int Id { get; init; }
    public required string Title { get; init; }
    public required string Suggestion { get; init; }
    public required bool IsCritical { get; init; }
}