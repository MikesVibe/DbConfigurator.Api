using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Features.DistributionInformationFeature;
using DbConfigurator.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.UnitTests.Common.Repositories
{
    public class FakeRecipientRepository : IRecipientRepository
    {
        public Task<Recipient> AddAsync(Recipient entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Recipient value)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsRangeAsync(IEnumerable<RecipientIdDto> recipientIds)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Recipient>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Recipient?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Recipient>> GetRecipientsAsync(ICollection<RecipientIdDto> recipientIds)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Recipient entity)
        {
            throw new NotImplementedException();
        }
    }
}
