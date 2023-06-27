using DbConfigurator.Api.IService;
using DbConfigurator.Api.Services;
using DbConfigurator.Api.Services.Repositories;
using DbConfigurator.API.DataAccess;
using DbConfigurator.API.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDbContext<DbConfiguratorApiDbContext>(
    dbContextOptions => dbContextOptions.UseSqlServer(
        builder.Configuration["ConnectionStrings:DbConfiguratorConnectionString"]));

builder.Services.AddScoped<IDistributionInformationService, DistributionInformationService>();
builder.Services.AddScoped<DistributionInformationRepository>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
