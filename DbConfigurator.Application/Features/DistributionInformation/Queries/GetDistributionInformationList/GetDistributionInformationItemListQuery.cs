using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature
{
    public class GetDistributionInformationItemListQuery : IRequest<IEnumerable<DistributionInformationItem>>
    {
    }
}
