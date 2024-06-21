using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.CountriesFeature.Commands.Delete
{
    public class DeleteCountryCommandHandler : DeleteCommandHandlerBase<Country, CountryDto, DeleteCountryCommand>,
        IRequestHandler<DeleteCountryCommand, Result>
    {
        public DeleteCountryCommandHandler(
            ICountryRepository countryRepository)
            : base(countryRepository)
        {
        }
    }
}
