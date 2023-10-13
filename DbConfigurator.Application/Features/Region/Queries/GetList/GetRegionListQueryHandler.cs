using DbConfigurator.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.Region
{
    public class GetRegionListQueryHandler : IRequestHandler<GetRegionListQuery, IEnumerable<RegionDto>>
    {
        public Task<IEnumerable<RegionDto>> Handle(GetRegionListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
