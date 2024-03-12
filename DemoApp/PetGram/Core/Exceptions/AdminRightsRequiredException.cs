using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace PetGram.Core.Exceptions;

public class AdminRightsRequiredException()
    : DomainException("Admin rights required to perform action")
{
    public override string ERROR_CODE => "ADMIN_RIGHTS_REQUIRED";

    public override ProblemDetails GetProblemDetails() => new()
    {
        Title = ERROR_CODE,
        Detail = Message,
        Status = (int)HttpStatusCode.Forbidden
    };
}