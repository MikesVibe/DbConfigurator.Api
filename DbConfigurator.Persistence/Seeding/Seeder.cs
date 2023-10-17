using DbConfigurator.Api.Services;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Persistence.Seeding
{
    public class Seeder : ISeeder
    {
        private readonly DbConfiguratorApiDbContext _dbConfiguratorDbContext;

        public Seeder(DbConfiguratorApiDbContext dbConfiguratorDbContext)
        {
            _dbConfiguratorDbContext = dbConfiguratorDbContext;
        }

        public async Task SeedAsync()
        {
            await SeedSingleClassAsync<Region>("Region.json");
            await SeedSingleClassAsync<DistributionInformation>("DistributionInformation.json");
        }

        private async Task SeedSingleClassAsync<T>(string fileName)
            where T : class
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(basePath, "Seeding", "SeedingData", fileName);

            var fromFile = File.ReadAllText(filePath);
            var entities = JsonConvert.DeserializeObject<IEnumerable<T>>(fromFile);

            foreach (var entity in entities)
            {
                if (entity is T region)
                {
                    _dbConfiguratorDbContext.Set<T>().Attach(entity).State = EntityState.Added;
                }
            }

            await _dbConfiguratorDbContext.SaveChangesAsync();
        }
    }
}
