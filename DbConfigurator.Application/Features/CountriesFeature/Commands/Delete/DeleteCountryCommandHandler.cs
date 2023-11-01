using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Delete;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
