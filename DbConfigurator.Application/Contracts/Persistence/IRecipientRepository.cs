using DbConfigurator.Application.Features.DistributionInformation.Commands.Update;
using DbConfigurator.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Contracts.Persistence
{
    public interface IRecipientRepository : IRepository<Recipient>
    {
        public Task<bool> ExistsRangeAsync(IEnumerable<RecipientIdDto> recipientIds);
        Task<ICollection<Recipient>> GetRecipientsAsync(ICollection<RecipientIdDto> recipientIds);
    }
}
