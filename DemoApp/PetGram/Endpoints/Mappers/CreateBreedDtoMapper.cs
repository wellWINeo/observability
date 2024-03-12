using PetGram.Core.Dto;
using PetGram.Core.Models;

namespace PetGram.Endpoints.Mappers;

internal static class CreateBreedDtoMapper
{
    public static Breed ToModel(this MutateBreedDto dto) => new()
    {
        Id = 0,
        Description = dto.Description,
        HealthIssues = dto.HealthIssueIds
            .Select(id => new HealthIssue { Id = id })
            .ToArray(),
        LifeSpan = dto.LifeSpan,
        TemperamentDescription = dto.TemperamentDescription,
        Name = dto.Name,
        OriginCountry = dto.Country,
        Size = dto.Size,
        SpeciesId = dto.SpeciesId
    };
}