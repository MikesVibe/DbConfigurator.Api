using AutoMapper;
using Azure.Core;
using DbConfigurator.Api.Services;
using DbConfigurator.API.DataAccess.Repository;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Create;
using DbConfigurator.Domain.Model.Entities;
using DbConfigurator.Domain.SecurityEntities;
using DbConfigurator.Persistence.DatabaseContext;
using DbConfigurator.Persistence.Repository;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace DbConfigurator.Persistence.Seeding
{
    public class Seeder : ISeeder
    {
        private readonly DbConfiguratorApiDbContext _dbConfiguratorDbContext;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IMapper _mapper;
        private readonly IRecipientRepository _recipientRepository;
        private readonly IDistributionInformationRepository _distributionInformationRepository;

        public Seeder(
            DbConfiguratorApiDbContext dbConfiguratorDbContext,
            UserManager<AppUser> userManager,
            RoleManager<AppRole> roleManager,
            IMapper mapper,
            IRecipientRepository recipientRepository,
            IDistributionInformationRepository distributionInformationRepository)
        {
            _dbConfiguratorDbContext = dbConfiguratorDbContext;
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
            _recipientRepository = recipientRepository;
            _distributionInformationRepository = distributionInformationRepository;
        }

        public async Task SeedAsync()
        {
            await SeedRegionAsync();
            await SeedDistributionInformationAsync();
            await SeedRoles();
            await SeedUsersAsync();
        }

        private async Task SeedUsersAsync()
        {
            string[] userNames = { "mikiAdmin", "mikiSA", "mikiDM" };
            string[] roles = { "Admin", "SecurityAnalyst", "DatabaseManager" };

            for (int i=0; i<3; i++)
            {
                var user = new AppUser() { UserName = userNames[i] };
                await _userManager.CreateAsync(user, "miki");
                await _userManager.AddToRoleAsync(user, roles[i]);
            }
        }
        private async Task SeedRoles()
        {
            var roles = new[] { "Admin", "Security Analyst", "Database Manager" };

            foreach (var role in roles)
            {
                if (!await _roleManager.RoleExistsAsync(role))
                    await _roleManager.CreateAsync(new AppRole(role));
            }
        }

        private async Task SeedRegionAsync()
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(basePath, "Seeding", "SeedingData", "Region.json");

            var fromFile = File.ReadAllText(filePath);
            var entities = JsonConvert.DeserializeObject<IEnumerable<Region>>(fromFile);

            foreach (var entity in entities)
            {
                if (entity is Region region)
                {
                    _dbConfiguratorDbContext.Set<Region>().Attach(entity).State = EntityState.Added;
                }
            }

            await _dbConfiguratorDbContext.SaveChangesAsync();
        }

        private async Task SeedDistributionInformationAsync()
        {
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(basePath, "Seeding", "SeedingData", "DistributionInformation.json");

            var fromFile = File.ReadAllText(filePath);
            var listOfDistributionInfo = JsonConvert.DeserializeObject<IEnumerable<CreateDistributionInformationDto>>(fromFile);



            foreach (var distributionInfo in listOfDistributionInfo)
            {
                var mapped = _mapper.Map<DistributionInformation>(distributionInfo);
                // Manually handle the relationships. Get real entities from database with Ids specified in request
                mapped.RecipientsTo = await _recipientRepository.GetRecipientsAsync(distributionInfo.RecipientsTo);
                mapped.RecipientsCc = await _recipientRepository.GetRecipientsAsync(distributionInfo.RecipientsCc);

                var result = await _distributionInformationRepository.AddAsync(mapped);
            }

            await _dbConfiguratorDbContext.SaveChangesAsync();
        }
    }
}
