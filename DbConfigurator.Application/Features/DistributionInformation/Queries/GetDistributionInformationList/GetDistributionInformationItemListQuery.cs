using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformation
{
    public class GetDistributionInformationItemListQuery : IRequest<IEnumerable<DistributionInformationItem>>
    {
    }
}
