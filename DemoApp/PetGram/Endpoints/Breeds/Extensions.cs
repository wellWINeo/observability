using PetGram.Filters;

namespace PetGram.Endpoints.Breeds;

public static class Extensions
{
    public static WebApplication MapBreeds(this WebApplication app)
    {
        var group = app
            .MapGroup("/api/breeds")
            .AddEndpointFilter<ExceptionFilter>();

        CreateBreedEndpoint.Map(group);
        GetBreedsEndpoint.Map(group);
        UpdateBreedEndpoint.Map(group);
        DeleteBreedEndpoint.Map(group);

        return app;
    }
}