using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.CountriesFeature.Commands.Update
{
    public class UpdateCountryCommand : IRequest<Result<CountryDto>>
    {
        public UpdateCountryDto Country { get; set; } = new UpdateCountryDto();
    }
}
