using PetGram.Core.Dto;
using PetGram.Core.Models;

namespace PetGram.Endpoints.Mappers;

public static class PetMapper
{
    public static PetDto ToDto(this Pet pet) => new()
    {
        Id = pet.Id,
        NickName = pet.NickName,
        Age = pet.Age,
        Gender = pet.Gender,
        Breed = pet.Breed!.ToDto(),
    };

    public static ICollection<PetDto> ToDtos(this ICollection<Pet> pets)
        => pets.Select(ToDto).ToList();
}
