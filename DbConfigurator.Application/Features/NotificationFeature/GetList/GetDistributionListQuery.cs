using MediatR;

namespace DbConfigurator.Application.Features.NotificationFeature.GetList
{
    public class GetDistributionListQuery : IRequest<DistributionListDto>
    {
        public NotificationDataDto NotificationData { get; set; } = new NotificationDataDto();
    }
}
