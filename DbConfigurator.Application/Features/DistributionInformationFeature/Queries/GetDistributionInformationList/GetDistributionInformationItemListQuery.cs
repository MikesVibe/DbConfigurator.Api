using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationList
{
    public class GetDistributionInformationItemListQuery : IRequest<IEnumerable<DistributionInformationItem>>
    {
    }
}
