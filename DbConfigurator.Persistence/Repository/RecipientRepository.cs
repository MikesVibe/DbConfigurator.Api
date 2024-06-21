using DbConfigurator.API.DataAccess.Repository;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Features.DistributionInformationFeature;
using DbConfigurator.Domain.Model.Entities;
using DbConfigurator.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace DbConfigurator.Persistence.Repository
{
    public class RecipientRepository : BaseRepository<Recipient>, IRecipientRepository
    {
        public RecipientRepository(DbConfiguratorApiDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> ExistsRangeAsync(IEnumerable<RecipientIdDto> recipientIds)
        {
            foreach (RecipientIdDto recipientId in recipientIds)
            {
                var response = await ExistsAsync(recipientId.Id);
                if (response == false)
                    return false;
            }
            return true;
        }

        public async Task<ICollection<Recipient>> GetRecipientsAsync(ICollection<RecipientIdDto> recipientIds)
        {
            IEnumerable<int> ids = recipientIds.Select(x => x.Id);
            return await _dbContext.Set<Recipient>().Where(r => ids.Contains(r.Id)).ToListAsync();
        }

    }
}
