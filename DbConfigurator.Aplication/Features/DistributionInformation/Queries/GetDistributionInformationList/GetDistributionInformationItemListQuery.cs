using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.DistributionInformation.Queries.GetDistributionInformationList
{
    public class GetDistributionInformationItemListQuery : IRequest<IEnumerable<DistributionInformationItem>>
    {
    }
}
