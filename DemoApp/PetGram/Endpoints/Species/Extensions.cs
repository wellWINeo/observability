using PetGram.Filters;

namespace PetGram.Endpoints.Species;

internal static class SpeciesEndpointsExtensions
{
    public static WebApplication MapSpecies(this WebApplication app)
    {
        var group = app
            .MapGroup("/api/species")
            .AddEndpointFilter<ExceptionFilter>();

        CreateSpeciesEndpoint.Map(group);
        GetSpeciesEndpoint.Map(group);
        UpdateSpeciesEndpoint.Map(group);
        DeleteSpeciesEndpoint.Map(group);

        return app;
    }
}