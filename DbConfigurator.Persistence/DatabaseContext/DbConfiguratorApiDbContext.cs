using DbConfigurator.Domain.Model.Entities;
using DbConfigurator.Domain.SecurityEntities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Reflection.Emit;

namespace DbConfigurator.Persistence.DatabaseContext
{
    public class DbConfiguratorApiDbContext : IdentityDbContext<
        AppUser,
        AppRole,
        int,
        IdentityUserClaim<int>,
        AppUserRole,
        IdentityUserLogin<int>,
        IdentityRoleClaim<int>,
        IdentityUserToken<int>>
    {
        public DbConfiguratorApiDbContext(DbContextOptions<DbConfiguratorApiDbContext> options)
        : base(options)
        {

        }

        public DbSet<DistributionInformation> DistributionInformation { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<BusinessUnit> BusinessUnit { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Priority> Priority { get; set; }
        public DbSet<RecipientGroupCc> RecipientGroupCc { get; set; }
        public DbSet<RecipientGroupTo> RecipientGroupTo { get; set; }
        public DbSet<Recipient> Recipient { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Setting up joining table for Recipients Groups
            modelBuilder.Entity<DistributionInformation>()
                .HasMany(g => g.RecipientsTo)
                .WithMany(r => r.RecipientGroupTo)
                .UsingEntity<RecipientGroupTo>();

            modelBuilder.Entity<DistributionInformation>()
                .HasMany(g => g.RecipientsCc)
                .WithMany(r => r.RecipientGroupCc)
                .UsingEntity<RecipientGroupCc>();

            modelBuilder.Entity<AppUser>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(u => u.User)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();

            modelBuilder.Entity<AppRole>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(u => u.Role)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();

            modelBuilder.HasDataFromFileAsync<Area>("Area.json");
            modelBuilder.HasDataFromFileAsync<BusinessUnit>("BusinessUnit.json");
            modelBuilder.HasDataFromFileAsync<Country>("Country.json");
            modelBuilder.HasDataFromFileAsync<Priority>("Priority.json");
            modelBuilder.HasDataFromFileAsync<Recipient>("Recipient.json");
        }
    }
    public static class Test
    {
        public static void HasDataFromFileAsync<T>(this ModelBuilder modelBuilder, string fileName)
            where T : class
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(basePath, "Seeding", "SeedingData", fileName);

            var fromFile = File.ReadAllText(filePath);
            var entities = JsonConvert.DeserializeObject<IEnumerable<T>>(fromFile);

            modelBuilder.Entity<T>().HasData(entities);
        }
    }

}