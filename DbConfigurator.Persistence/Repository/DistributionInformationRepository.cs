using DbConfigurator.Api.Models;
using DbConfigurator.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DbConfigurator.API.DataAccess.Repository
{
    public class DistributionInformationRepository : BaseRepository<DistributionInformation>, IDistributionInformationRepository
    {
        public DistributionInformationRepository(DbConfiguratorApiDbContext dbContext) : base(dbContext)
        {
        }

        public async Task AddRecipients(int disInfoId, IEnumerable<int> recipientIds)
        {
            // Retrieve the DistributionInformation entity with the specified disInfoId
            var distributionInformation = await QueryableDistributionInformation()
                .FirstOrDefaultAsync(di => di.Id == disInfoId);

            if (distributionInformation == null)
            {
                throw new ArgumentException("DistributionInformation not found with the specified Id.", nameof(disInfoId));
            }

            // Fetch the Recipient entities from the provided recipientIds
            var recipientsToAdd = await _dbContext.Recipient
                .Where(r => recipientIds.Contains(r.Id))
                .ToListAsync();

            // Add the fetched Recipient entities to the appropriate navigation properties
            foreach (var recipientId in recipientIds)
            {
                var recipient = recipientsToAdd.FirstOrDefault(r => r.Id == recipientId);
                if (recipient != null)
                {
                    distributionInformation.RecipientsTo.Add(recipient);
                }
            }

            // Save the changes to the database
            await _dbContext.SaveChangesAsync();
        }

        public override async Task<IEnumerable<DistributionInformation>> GetAllAsync()
        {
            return await QueryableDistributionInformation()
                .AsNoTracking().ToListAsync();
        }
        public override async Task<DistributionInformation?> GetByIdAsync(int id)
        {
            return await QueryableDistributionInformation()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        private IQueryable<DistributionInformation> QueryableDistributionInformation()
        {
            return _dbContext.Set<DistributionInformation>()
                .Include(d => d.Region)
                    .ThenInclude(r => r.Area)
                .Include(d => d.Region)
                    .ThenInclude(r => r.BuisnessUnit)
                .Include(d => d.Region)
                    .ThenInclude(r => r.Country)
                .Include(d => d.RecipientsCc)
                .Include(d => d.RecipientsTo)
                .Include(d => d.Priority)
                .AsQueryable();
        }
    }
}
