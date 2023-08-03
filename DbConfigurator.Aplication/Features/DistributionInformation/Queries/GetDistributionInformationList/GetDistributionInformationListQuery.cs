using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformationList
{
    public class GetDistributionInformationListQuery : IRequest<IEnumerable<DistributionInformationItem>>
    {
    }
}
