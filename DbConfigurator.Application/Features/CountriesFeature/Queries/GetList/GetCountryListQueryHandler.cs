using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using MediatR;

namespace DbConfigurator.Application.Features.CountriesFeature.Queries.GetList
{
    public class GetCountryListQueryHandler : GetListQueryHandlerBase<Country, CountryDto, GetCountryListQuery>,
        IRequestHandler<GetCountryListQuery, IEnumerable<CountryDto>>
    {
        public GetCountryListQueryHandler(
            ICountryRepository countryRepository,
            IMapper mapper) : base(countryRepository, mapper)
        {
        }
    }
}
