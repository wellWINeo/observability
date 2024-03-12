using Elastic.Extensions.Logging;
using Elastic.Extensions.Logging.Options;
using Microsoft.EntityFrameworkCore;
using PetGram.Core.Options;
using PetGram.Data;
using PetGram.Data.Repositories;
using PetGram.Endpoints.Breeds;
using PetGram.Endpoints.HealthIssues;
using PetGram.Endpoints.Pets;
using PetGram.Endpoints.Species;
using PetGram.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddOptions<AdminOptions>()
    .Bind(builder.Configuration.GetSection(nameof(AdminOptions)));

builder.Services.AddDbContext<PetShopDbContext>(options
    => options.UseNpgsql(
        builder.Configuration.GetConnectionString("PetShopDb")
    )
);

builder.Services.AddLogging(logging =>
{
    logging.AddConsole();
    logging.AddElasticsearch(options =>
    {
        options.ShipTo = new ShipToOptions()
        {
            NodePoolType = NodePoolType.SingleNode,
            NodeUris = [new("http://localhost:9200")]
        };
    });
});

builder.Services
    .AddScoped<BreedsRepository>()
    .AddScoped<HealthIssueRepository>()
    .AddScoped<PetsRepository>()
    .AddScoped<SpeciesRepository>()
    ;

builder.Services
    .AddScoped<PetsService>()
    .AddScoped<BreedsService>()
    .AddScoped<SpeciesService>()
    .AddScoped<HealthIssuesService>()
    ;

var app = builder.Build();

app
    .MapPets()
    .MapBreeds()
    .MapSpecies()
    .MapHealthIssues()
    ;

await app.RunAsync();