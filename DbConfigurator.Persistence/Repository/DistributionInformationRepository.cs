using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Domain.Model.Entities;
using DbConfigurator.Persistence;
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
            var distributionInformation = await GetAllQueryable()
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

        protected override IQueryable<DistributionInformation> GetAllQueryable()
        {
            return _dbContext.Set<DistributionInformation>()
                .Include(d => d.Region)
                    .ThenInclude(r => r.Area)
                .Include(d => d.Region)
                    .ThenInclude(r => r.BusinessUnit)
                .Include(d => d.Region)
                    .ThenInclude(r => r.Country)
                .Include(d => d.RecipientsCc)
                .Include(d => d.RecipientsTo)
                .Include(d => d.Priority)
                .AsQueryable();
        }
    }
}
