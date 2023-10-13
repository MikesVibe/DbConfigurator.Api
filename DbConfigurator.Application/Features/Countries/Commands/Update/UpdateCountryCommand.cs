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
    public class UpdateCountryCommand : IRequest<Result<CountryDto>>
    {
        public CountryDto Country { get; set; } = new CountryDto();
    }
}
