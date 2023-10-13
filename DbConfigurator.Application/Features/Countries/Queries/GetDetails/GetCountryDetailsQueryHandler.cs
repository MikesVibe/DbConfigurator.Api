using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.Country
{
    public class GetCountryDetailsQueryHandler : IRequestHandler<GetCountryDetailsQuery, Result<CountryDto>>
    {
        public async Task<Result<CountryDto>> Handle(GetCountryDetailsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
