using PetGram.Core.Dto;

namespace PetGram.Endpoints.Mappers;

internal static class SpeciesMappings
{
    // Species -> SpeciesDto
    public static SpeciesDto ToDto(this Core.Models.Species species) => new()
    {
        Id = species.Id,
        Name = species.Name,
        Description = species.Description
    };

    public static ICollection<SpeciesDto> ToDtos(this ICollection<Core.Models.Species> species)
        => species.Select(ToDto).ToList();
    
    // CreateSpeciesDto -> Species
    public static Core.Models.Species ToModel(this MutateSpeciesDto dto, int id = 0) => new()
    {
        Id = id,
        Name = dto.Name,
        Description = dto.Description
    };
}