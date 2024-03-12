namespace PetGram.Core.Logging;

public static class InternalEventId
{
    public const int ExpiredCacheCleared = 2_000;
    public const int CacheValueReturned = 2_005;
    public const int CacheValueMissed = 2_010;
    public const int CacheReturnedActualValue = 2_015;
    public const int CacheRetrievedNullActualValue = 2020;
}