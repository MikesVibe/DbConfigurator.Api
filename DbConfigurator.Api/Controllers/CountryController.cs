using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Create;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Delete;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Update;
using DbConfigurator.Application.Features.CountriesFeature.Queries.GetDetails;
using DbConfigurator.Application.Features.CountriesFeature.Queries.GetList;
using MediatR;

namespace DbConfigurator.Api.Controllers
{
    public class CountryController : GenericController<
        CreateCountryCommand, UpdateCountryCommand, DeleteCountryCommand,
        CreateCountryDto, UpdateCountryDto,
        GetCountryDetailsQuery, GetCountryListQuery,
        CountryDto>
    {
        public CountryController(IMediator mediator)
            : base(mediator)
        {
        }
    }
}
