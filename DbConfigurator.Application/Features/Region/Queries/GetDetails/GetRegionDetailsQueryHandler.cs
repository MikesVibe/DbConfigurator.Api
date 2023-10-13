using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.Region
{
    public class GetRegionDetailsQueryHandler : IRequestHandler<GetRegionDetailsQuery, Result<RegionDto>>
    {
        public async Task<Result<RegionDto>> Handle(GetRegionDetailsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
