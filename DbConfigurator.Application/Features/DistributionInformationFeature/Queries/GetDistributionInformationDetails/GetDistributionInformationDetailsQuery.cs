using DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationList;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationDetails
{
    public class GetDistributionInformationDetailsQuery : IRequest<DistributionInformationItem>
    {
        public GetDistributionInformationDetailsQuery()
        {
        }

        public int Id { get; set; }
    }
}
