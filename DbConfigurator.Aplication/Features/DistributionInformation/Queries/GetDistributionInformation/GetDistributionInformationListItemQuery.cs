using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformation
{
    public class GetDistributionInformationListItemQuery : IRequest<IEnumerable<DistributionInformationListItem>>
    {
    }
}
