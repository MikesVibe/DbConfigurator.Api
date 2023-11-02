using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.RecipientFeature.Commands.Create;
using DbConfigurator.Application.Features.RecipientFeature.Commands.Delete;
using DbConfigurator.Application.Features.RecipientFeature.Commands.Update;
using DbConfigurator.Application.Features.RecipientFeature.Queries.GetDetails;
using DbConfigurator.Application.Features.RecipientFeature.Queries.GetList;
using DbConfigurator.Application.Features.RegionFeature;
using DbConfigurator.Application.Features.RegionFeature.Commands.Create;
using DbConfigurator.Application.Features.RegionFeature.Commands.Delete;
using DbConfigurator.Application.Features.RegionFeature.Commands.Update;
using DbConfigurator.Application.Features.RegionFeature.Queries.GetDetails;
using DbConfigurator.Application.Features.RegionFeature.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    public class RegionController : GenericController<
        CreateRegionCommand, UpdateRegionCommand, DeleteRegionCommand,
        CreateRegionDto, UpdateRegionDto,
        GetRegionDetailsQuery, GetRegionListQuery,
        RegionDto>
    {
        public RegionController(IMediator mediator)
            : base(mediator)
        {
        }
    }
}
