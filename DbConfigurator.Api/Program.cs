using DbConfigurator.Api;
using DbConfigurator.Api.Services;
using DbConfigurator.API.DataAccess;
using DbConfigurator.API.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using System.Reflection;



var builder = WebApplication.CreateBuilder(args);

var app = builder
       .ConfigureServices()
       .ConfigurePipeline();

app.Run();
