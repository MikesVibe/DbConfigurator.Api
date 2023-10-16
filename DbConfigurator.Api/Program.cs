using DbConfigurator.Api;

var builder = WebApplication.CreateBuilder(args);

var app = builder
       .ConfigureServices()
       .ConfigurePipeline();

await app.CreateDatabaseAsync();

app.Run();
