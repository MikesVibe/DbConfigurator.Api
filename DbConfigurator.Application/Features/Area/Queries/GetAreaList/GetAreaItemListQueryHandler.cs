using DbConfigurator.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.Area
{
    public class GetAreaItemListQueryHandler : IRequestHandler<GetAreaItemListQuery, IEnumerable<AreaDto>>
    {
        public async Task<IEnumerable<AreaDto>> Handle(GetAreaItemListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            //await Task.Delay(0);
            //return new List<AreaDto>();
        }
    }
}
