using DbConfigurator.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.Country
{
    public class GetCountryListQueryHandler : IRequestHandler<GetCountryListQuery, IEnumerable<CountryDto>>
    {
        public Task<IEnumerable<CountryDto>> Handle(GetCountryListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
