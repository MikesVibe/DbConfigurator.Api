using DbConfigurator.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.Priority
{
    public class GetPriorityListQueryHandler : IRequestHandler<GetPriorityListQuery, IEnumerable<PriorityDto>>
    {
        public Task<IEnumerable<PriorityDto>> Handle(GetPriorityListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
