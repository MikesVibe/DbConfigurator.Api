using DbConfigurator.API.DataAccess;
using DbConfigurator.API.DataAccess.Repository;
using DbConfigurator.Aplication.Contracts.Persistence;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            services.AddScoped<IDistributionInformationRepository, DistributionInformationRepository>();
            services.AddScoped<IRegionRepository, RegionRepository>();
            services.AddScoped<IPriorityRepository, PriorityRepository>();

            return services;
        }
    }
}
