using PetGram.Core.Dto;
using PetGram.Core.Models;

namespace PetGram.Endpoints.Mappers;

public static class CreatePetDtoMapper
{
    public static Pet ToModel(this MutatePetDto dto, int id = 0) => new()
    {
        Id = id,
        NickName = dto.NickName,
        Age = dto.Age,
        Gender = dto.Gender,
        BreedId = dto.BreedId,
    };
}
