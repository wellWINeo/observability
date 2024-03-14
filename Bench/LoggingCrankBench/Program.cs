using LoggingCrankBench.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddFilter(nameof(IncrementEndpoint), LogLevel.Information);

var app = builder.Build();

app.MapGet("/increment/no-log/{value:int}", IncrementEndpoint.NoLog);
app.MapGet("/increment/std-log/{value:int}", IncrementEndpoint.StandardLog);
app.MapGet("/increment/sourcegen-log/{value:int}", IncrementEndpoint.SourceGenLog);
app.MapGet("/increment/defined-log/{value:int}", IncrementEndpoint.DefinedLog);
app.MapGet("/increment/suppress-log/{value:int}", IncrementEndpoint.SuppressLog);

app.Run("http://*:5020");