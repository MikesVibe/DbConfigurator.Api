using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.BusinessUnit
{
    public class GetBusinessUnitDetailsQueryHandler : IRequestHandler<GetBusinessUnitDetailsQuery, Result<BusinessUnitDto>>
    {
        public async Task<Result<BusinessUnitDto>> Handle(GetBusinessUnitDetailsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
