using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Persistence
{
    public class DbConfiguratorApiDbContextFactory : IDesignTimeDbContextFactory<DbConfiguratorApiDbContext>
    {
        public DbConfiguratorApiDbContext CreateDbContext(string[] args)
        {
            var basePath = Directory.GetParent(Directory.GetCurrentDirectory())
                ?.GetDirectories("DbConfigurator.Api").FirstOrDefault()?.FullName;

            if (string.IsNullOrEmpty(basePath))
            {
                throw new InvalidOperationException("Could not find the directory of the DbConfigurator.Api project.");
            }


            // Build configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddNewtonsoftJsonFile("appsettings.json")
                .Build();

            // Get connection string
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<DbConfiguratorApiDbContext>();
            optionsBuilder.UseSqlServer(connectionString);  // Adjust for your database provider

            return new DbConfiguratorApiDbContext(optionsBuilder.Options);
        }

    }
}
