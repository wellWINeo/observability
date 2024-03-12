using PetGram.Core.Dto;
using PetGram.Core.Models;

namespace PetGram.Endpoints.Mappers;

public static class BreedMapper
{
    public static BreedDto ToDto(this Breed breed) => new()
    {
        Id = breed.Id,
        Name = breed.Name,
        Description = breed.Description,
        OriginCountry = breed.OriginCountry,
        Size = breed.Size,
        LifeSpan = breed.LifeSpan,
        TemperamentDescription = breed.TemperamentDescription,
        HealthIssues = breed.HealthIssues.ToDtos(),
    };

    public static ICollection<BreedDto> ToDtos(this ICollection<Breed> breeds)
        => breeds.Select(ToDto).ToList();
}
