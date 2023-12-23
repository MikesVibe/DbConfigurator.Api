using DbConfigurator.Api;

var builder = WebApplication.CreateBuilder(args);

var app = await builder
       .ConfigureServices()
       .ConfigurePipelineAsync();

await app.CreateDatabaseAsync();

app.Run();
