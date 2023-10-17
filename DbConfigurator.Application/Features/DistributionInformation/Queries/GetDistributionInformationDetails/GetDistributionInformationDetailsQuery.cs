using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature
{
    public class GetDistributionInformationDetailsQuery : IRequest<DistributionInformationItem>
    {
        public GetDistributionInformationDetailsQuery()
        {
        }

        public int Id { get; set; }
    }
}
