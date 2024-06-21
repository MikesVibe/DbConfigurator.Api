using DbConfigurator.Application.Features.DistributionInformationFeature;
using DbConfigurator.Domain.Model.Entities;

namespace DbConfigurator.Application.Contracts.Persistence
{
    public interface IRecipientRepository : IRepository<Recipient>
    {
        public Task<bool> ExistsRangeAsync(IEnumerable<RecipientIdDto> recipientIds);
        Task<ICollection<Recipient>> GetRecipientsAsync(ICollection<RecipientIdDto> recipientIds);
    }
}
