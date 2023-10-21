using DbConfigurator.API.DataAccess;
using DbConfigurator.Application;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Domain.SecurityEntities;
using DbConfigurator.Persistence;
using DbConfigurator.Persistence.DatabaseContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace DbConfigurator.Api
{
    public static class StartupExtension
    {
        public static WebApplication ConfigureServices(
            this WebApplicationBuilder builder)
        {


            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "DbConfiguration_API",
                    Version = "v1",
                });
                c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                    Description = "Here Enter JWT Token with bearer format:"
                });
                c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
                {
                    {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[]{ }
                    }
                });
            });

            builder.Services.AddApplicationServices();
            builder.Services.AddPersistenceServices(builder.Configuration);

            builder.Services.AddHttpContextAccessor();

            //builder.Services.AddIdentity<AppUser, IdentityRole>() 
            //    .AddEntityFrameworkStores<SecurityContext>() 
            //    .AddDefaultTokenProviders();

            builder.Services.AddControllers();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            });

            builder.Services.AddAuthentication("Bearer")
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = builder.Configuration["Authentication:Issuer"],
                        ValidAudience = builder.Configuration["Authentication:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(builder.Configuration["Authentication:SecretForKey"]))
                    };
                });
            builder.Services.AddIdentityCore<AppUser>(opt =>
            {
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequiredLength = 3;
            })
    .AddRoles<AppRole>()
    .AddRoleManager<RoleManager<AppRole>>()
    .AddEntityFrameworkStores<DbConfiguratorApiDbContext>();

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

            app.UseCors("Open");
            app.UseAuthentication();
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

            //if (await context.Database.CanConnectAsync())
            //    return;

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
