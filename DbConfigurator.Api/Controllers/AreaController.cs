using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.AreaFeature.Commands.Create;
using DbConfigurator.Application.Features.AreaFeature.Commands.Delete;
using DbConfigurator.Application.Features.AreaFeature.Commands.Update;
using DbConfigurator.Application.Features.AreaFeature.Queries.GetAreaDetails;
using DbConfigurator.Application.Features.AreaFeature.Queries.GetAreaList;
using MediatR;

namespace DbConfigurator.Api.Controllers
{
    public class AreaController : GenericController<
        CreateAreaCommand, UpdateAreaCommand, DeleteAreaCommand,
        CreateAreaDto, UpdateAreaDto,
        GetAreaDetailsQuery, GetAreaItemListQuery,
        AreaDto>
    {
        public AreaController(IMediator mediator)
            : base(mediator)
        {
        }
    }
}
