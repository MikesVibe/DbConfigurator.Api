using DbConfigurator.Application.Features.DistributionInformation.Queries.GetDistributionInformationList;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.DistributionInformation.Queries.GetDistributionInformationDetails
{
    public class GetDistributionInformationDetailsQuery : IRequest<DistributionInformationItem>
    {
        public GetDistributionInformationDetailsQuery()
        {
        }

        public int Id { get; set; }
    }
}
