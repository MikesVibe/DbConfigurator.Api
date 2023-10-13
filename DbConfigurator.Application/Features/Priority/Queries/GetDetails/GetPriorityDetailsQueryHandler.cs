using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.Priority
{
    public class GetPriorityDetailsQueryHandler : IRequestHandler<GetPriorityDetailsQuery, Result<PriorityDto>>
    {
        public async Task<Result<PriorityDto>> Handle(GetPriorityDetailsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
