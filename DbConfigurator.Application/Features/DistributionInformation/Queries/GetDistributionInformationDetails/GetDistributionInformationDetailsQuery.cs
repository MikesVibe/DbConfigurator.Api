using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformation
{
    public class GetDistributionInformationDetailsQuery : IRequest<DistributionInformationItem>
    {
        public GetDistributionInformationDetailsQuery()
        {
        }

        public int Id { get; set; }
    }
}
