using System.ComponentModel.DataAnnotations;
using PetGram.Core.Models;

namespace PetGram.Core.Dto;

public class MutatePetDto
{
    [Length(1, 50)]
    public required string NickName { get; init; }

    public required int Age { get; init; }
    public required Gender Gender { get; init; }
    public required int BreedId { get; init; }
}
