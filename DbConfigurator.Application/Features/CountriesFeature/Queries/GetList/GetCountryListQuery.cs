using DbConfigurator.Application.Contracts.Features.GetList;
using DbConfigurator.Application.Dtos;
using MediatR;

namespace DbConfigurator.Application.Features.CountriesFeature.Queries.GetList
{
    public class GetCountryListQuery : IRequest<IEnumerable<CountryDto>>, IGetListQuery
    {
    }
}
