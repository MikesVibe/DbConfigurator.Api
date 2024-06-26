﻿using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.CountriesFeature.Commands.Update
{
    public class UpdateCountryCommandHandler : UpdateCommandHandlerBase<Country, CountryDto, UpdateCountryCommand>,
        IRequestHandler<UpdateCountryCommand, Result>
    {
        public UpdateCountryCommandHandler(
            ICountryRepository countryRepository,
            IMapper mapper) : base(countryRepository, mapper)
        {
        }
    }
}
