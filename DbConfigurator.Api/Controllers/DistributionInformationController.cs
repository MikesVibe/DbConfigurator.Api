using Azure;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Create;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Delete;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Update;
using DbConfigurator.Application.Features.CountriesFeature.Queries.GetDetails;
using DbConfigurator.Application.Features.CountriesFeature.Queries.GetList;
using DbConfigurator.Application.Features.DistributionInformationFeature;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Create;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Delete;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Update;
using DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationDetails;
using DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    public class DistributionInformationController : GenericController<
        CreateDistributionInformationCommand, UpdateDistributionInformationCommand, DeleteDistributionInfomationCommand,
        CreateDistributionInformationDto, UpdateDistributionInformationDto,
        GetDistributionInformationDetailsQuery, GetDistributionInformationItemListQuery,
        DistributionInformationDto>
    {
        public DistributionInformationController(IMediator mediator)
            :base(mediator) 
        {
        }
    }
}
