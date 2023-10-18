using DbConfigurator.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Queries.GetList
{
    public class GetBusinessUnitListQuery : IRequest<IEnumerable<BusinessUnitDto>>
    {
    }
}
