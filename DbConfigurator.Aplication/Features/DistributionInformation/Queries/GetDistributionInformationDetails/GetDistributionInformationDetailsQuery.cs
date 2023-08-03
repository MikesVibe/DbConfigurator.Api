using DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformationList;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformationDetails
{
    public class GetDistributionInformationDetailsQuery : IRequest<DistributionInformationItem>
    {
        public GetDistributionInformationDetailsQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
