using DbConfigurator.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.BusinessUnit
{
    public class GetBusinessUnitListQueryHandler : IRequestHandler<GetBusinessUnitListQuery, IEnumerable<BusinessUnitDto>>
    {
        public Task<IEnumerable<BusinessUnitDto>> Handle(GetBusinessUnitListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
