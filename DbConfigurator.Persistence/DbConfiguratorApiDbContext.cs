using DbConfigurator.Api.Models;
using DbConfigurator.Model.Entities.Core;
using Microsoft.EntityFrameworkCore;

namespace DbConfigurator.API.DataAccess
{
    public class DbConfiguratorApiDbContext : DbContext
    {
        public DbConfiguratorApiDbContext(DbContextOptions<DbConfiguratorApiDbContext> options)
        : base(options)
        {

        }

        public DbSet<DistributionInformation> DistributionInformation { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<BuisnessUnit> BuisnessUnit { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Priority> Priority { get; set; }
        public DbSet<RecipientGroupCc> RecipientGroupCc { get; set; }
        public DbSet<RecipientGroupTo> RecipientGroupTo { get; set; }
        public DbSet<Recipient> Recipient { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Setting up joining table for Recipients Groups
            modelBuilder.Entity<DistributionInformation>()
                .HasMany(g => g.RecipientsTo)
                .WithMany(r => r.RecipientGroupTo)
                .UsingEntity<RecipientGroupTo>();

            modelBuilder.Entity<DistributionInformation>()
                .HasMany(g => g.RecipientsCc)
                .WithMany(r => r.RecipientGroupCc)
                .UsingEntity<RecipientGroupCc>();
        }
    }
}