namespace PetGram.Core.Logging;

public static class ApplicationEventId
{
    public const int RequestFailed = 1_000;
    public const int UnprocessibleRequest = 1_010;
    public const int CreatePet = 1_020;
}