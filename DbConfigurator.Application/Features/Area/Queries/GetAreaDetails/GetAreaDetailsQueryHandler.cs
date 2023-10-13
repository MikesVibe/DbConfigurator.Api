using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.Area
{
    public class GetAreaDetailsQueryHandler : IRequestHandler<GetAreaDetailsQuery, Result<AreaDto>>
    {
        public async Task<Result<AreaDto>> Handle(GetAreaDetailsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
