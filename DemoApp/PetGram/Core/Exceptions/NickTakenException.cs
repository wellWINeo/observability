namespace PetGram.Core.Exceptions;

public class NickTakenException(string nickName, Exception? innerException = null) 
    : DomainException($"Nick {nickName} already taken", innerException)
{
    public override string ERROR_CODE => "NICKNAME_TAKEN";
}