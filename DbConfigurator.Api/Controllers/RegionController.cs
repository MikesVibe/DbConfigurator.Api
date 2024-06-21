using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.RegionFeature.Commands.Create;
using DbConfigurator.Application.Features.RegionFeature.Commands.Delete;
using DbConfigurator.Application.Features.RegionFeature.Commands.Update;
using DbConfigurator.Application.Features.RegionFeature.Queries.GetDetails;
using DbConfigurator.Application.Features.RegionFeature.Queries.GetList;
using MediatR;

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
