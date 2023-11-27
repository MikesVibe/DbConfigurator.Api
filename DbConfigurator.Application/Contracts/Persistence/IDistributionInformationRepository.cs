using DbConfigurator.Application.Features.NotificationFeature;
using DbConfigurator.Domain.Model.Entities;

namespace DbConfigurator.Application.Contracts.Persistence
{
    public interface IDistributionInformationRepository : IRepository<DistributionInformation>
    {
        Task<Tuple<IEnumerable<Recipient>, IEnumerable<Recipient>>> GetDistributionListBySingleName(NotificationDataDto notificationData);
    }
}
