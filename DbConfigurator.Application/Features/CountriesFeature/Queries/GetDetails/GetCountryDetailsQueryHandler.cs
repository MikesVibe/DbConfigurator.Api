using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.CountriesFeature.Queries.GetDetails
{
    public class GetCountryDetailsQueryHandler : GetDetailQueryHandlerBase<Country, CountryDto, GetCountryDetailsQuery>,
        IRequestHandler<GetCountryDetailsQuery, Result<CountryDto>>
    {
        public GetCountryDetailsQueryHandler(
            ICountryRepository countryRepository,
            IMapper mapper) : base(countryRepository, mapper)
        {
        }
    }
}
