using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DbConfigurator.Persistence.DatabaseContext
{
    public class DbConfiguratorApiDbContextFactory : IDesignTimeDbContextFactory<DbConfiguratorApiDbContext>
    {
        private readonly IConfiguration _configuration;

        public DbConfiguratorApiDbContextFactory()
        {

        }
        public DbConfiguratorApiDbContextFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbConfiguratorApiDbContext CreateDbContext(string[] args)
        {
            var basePath = Directory.GetParent(Directory.GetCurrentDirectory())
                ?.GetDirectories("DbConfigurator.Api").FirstOrDefault()?.FullName;

            if (string.IsNullOrEmpty(basePath))
            {
                throw new InvalidOperationException("Could not find the directory of the DbConfigurator.Api project.");
            }

            // Get connection string
            var connectionString = _configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<DbConfiguratorApiDbContext>();
            optionsBuilder.UseSqlServer(connectionString);  // Adjust for your database provider

            return new DbConfiguratorApiDbContext(optionsBuilder.Options);
        }

    }
}
