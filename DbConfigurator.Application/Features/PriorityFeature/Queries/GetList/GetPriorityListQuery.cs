using DbConfigurator.Application.Contracts.Features.GetList;
using DbConfigurator.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.PriorityFeature.Queries.GetList
{
    public class GetPriorityListQuery : IRequest<IEnumerable<PriorityDto>>, IGetListQuery
    {
    }
}
