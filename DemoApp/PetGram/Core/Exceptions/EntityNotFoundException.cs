using System.Net;
using Microsoft.AspNetCore.Mvc;
using PetGram.Core.Models.Internal;

namespace PetGram.Core.Exceptions;

public class EntityNotFoundException<T>(int id) 
    : DomainException($"{typeof(T).Name} entity with id {id} not found") 
    where T : IEntity
{
    public override string ERROR_CODE => "ENTITY_NOT_FOUND";

    public override ProblemDetails GetProblemDetails() => new()
    {
        Title = ERROR_CODE,
        Detail = Message,
        Status = (int)HttpStatusCode.NotFound
    };
}