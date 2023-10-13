using DbConfigurator.API.DataAccess;
using DbConfigurator.API.DataAccess.Repository;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Model.Entities.Core;
using DbConfigurator.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DbConfigurator.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbConfiguratorApiDbContext>(
                dbContextOptions => dbContextOptions.UseSqlServer(
                    configuration["ConnectionStrings:DbConfiguratorConnectionString"]));

            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));


            services.AddScoped<IAreaRepository, AreaRepository>();
            services.AddScoped<IBusinessUnitRepository, BusinessUnitRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<IDistributionInformationRepository, DistributionInformationRepository>();
            services.AddScoped<IRecipientRepository, RecipientRepository>();
            services.AddScoped<IRegionRepository, RegionRepository>();
            services.AddScoped<IPriorityRepository, PriorityRepository>();

            return services;
        }
    }
}
