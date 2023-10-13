using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.Country
{
    public class CreateCountryCommand : IRequest<Result<CountryDto>>
    {
        public CountryDto Country { get; set; } = new CountryDto();
    }
}
