using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.CountriesFeature.Commands.Create
{
    public class CreateCountryCommand : IRequest<Result<CountryDto>>
    {
        public CreateCountryDto Country { get; set; } = new CreateCountryDto();
    }
}
