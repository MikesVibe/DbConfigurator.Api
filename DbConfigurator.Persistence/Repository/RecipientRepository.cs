using DbConfigurator.API.DataAccess;
using DbConfigurator.API.DataAccess.Repository;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Features.DistributionInformation.Commands.Update;
using DbConfigurator.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
