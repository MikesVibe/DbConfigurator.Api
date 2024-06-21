using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.CountriesFeature.Commands.Create
{
    public class CreateCountryCommandHandler : CreateCommandHandlerBase<Country, CountryDto, CreateCountryCommand>,
        IRequestHandler<CreateCountryCommand, Result<CountryDto>>
    {
        public CreateCountryCommandHandler(
            ICountryRepository countryRepository,
            IMapper mapper) : base(countryRepository, mapper)
        {
        }
    }
}
