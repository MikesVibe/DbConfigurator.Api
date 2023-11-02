using Azure;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Create;
using DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Delete;
using DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Update;
using DbConfigurator.Application.Features.BusinessUnitFeature.Queries.GetDetails;
using DbConfigurator.Application.Features.BusinessUnitFeature.Queries.GetList;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Create;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Delete;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Update;
using DbConfigurator.Application.Features.CountriesFeature.Queries.GetDetails;
using DbConfigurator.Application.Features.CountriesFeature.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
