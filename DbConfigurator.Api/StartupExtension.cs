﻿using DbConfigurator.API.DataAccess;
using DbConfigurator.Application;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DbConfigurator.Api
{
    public static class StartupExtension
    {
        public static WebApplication ConfigureServices(
            this WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();

            builder.Services.AddApplicationServices();
            builder.Services.AddPersistenceServices(builder.Configuration);

            builder.Services.AddHttpContextAccessor();

            builder.Services.AddControllers();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            });

            return builder.Build();

        }

        public static WebApplication ConfigurePipeline(this WebApplication app)
        {

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "GloboTicket Ticket Management API");
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseCors("Open");

            app.UseAuthorization();

            app.MapControllers();

            return app;

        }

        public static async Task CreateDatabaseAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            var context = scope.ServiceProvider.GetService<DbConfiguratorApiDbContext>();
            if (context is null)
                return;

            if (await context.Database.CanConnectAsync())
                return;

            await context.Database.EnsureDeletedAsync();
            await context.Database.MigrateAsync();

            var seeder = scope.ServiceProvider.GetService<ISeeder>();
            if (seeder is null)
                return;

            await seeder.SeedAsync();

            try
            {

            }
            catch (Exception ex)
            {
                //var logger = scope.ServiceProvider.GetRequiredService<ILogger>();
                //logger.LogError(ex, "An error occurred while migrating the database.");
            }
        }
    }
}
