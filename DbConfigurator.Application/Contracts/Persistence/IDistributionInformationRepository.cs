using DbConfigurator.Domain.Model.Entities;

namespace DbConfigurator.Application.Contracts.Persistence
{
    public interface IDistributionInformationRepository : IRepository<DistributionInformation>
    {
        Task AddRecipients(int disInfoId, IEnumerable<int> recipientIds);
    }
}
