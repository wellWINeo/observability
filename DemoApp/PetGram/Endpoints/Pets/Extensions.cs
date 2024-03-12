namespace PetGram.Endpoints.Pets;

public static class Extensions
{
    public static WebApplication MapPets(this WebApplication app)
    {
        var group = app.MapGroup("/api/pets");

        CreatePetEndpoint.Map(group);
        DeletePetEndpoint.Map(group);
        GetPetByIdEndpoint.Map(group);
        GetPetsByNamesEndpoint.Map(group);
        UpdatePetEndpoint.Map(group);

        return app;
    }
}