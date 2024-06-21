using DbConfigurator.Application.Contracts.Features.GetDetail;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.CountriesFeature.Queries.GetDetails
{
    public class GetCountryDetailsQuery : IRequest<Result<CountryDto>>, IGetDetailQuery
    {
        public int Id { get; set; }
    }
}
