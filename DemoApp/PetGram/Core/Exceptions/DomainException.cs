using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace PetGram.Core.Exceptions;

public abstract class DomainException(string message, Exception? innerException = null)
    : Exception(message, innerException)
{
    public abstract string ERROR_CODE { get; }

    public virtual ProblemDetails GetProblemDetails() => new()
    {
        Title = ERROR_CODE,
        Detail = Message,
        Status = (int)HttpStatusCode.UnprocessableEntity
    };
}