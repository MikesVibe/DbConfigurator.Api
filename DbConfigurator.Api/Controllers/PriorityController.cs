using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.PriorityFeature.Commands.Create;
using DbConfigurator.Application.Features.PriorityFeature.Commands.Delete;
using DbConfigurator.Application.Features.PriorityFeature.Commands.Update;
using DbConfigurator.Application.Features.PriorityFeature.Queries.GetDetails;
using DbConfigurator.Application.Features.PriorityFeature.Queries.GetList;
using MediatR;

namespace DbConfigurator.Api.Controllers
{
    public class PriorityController : GenericController<
        CreatePriorityCommand, UpdatePriorityCommand, DeletePriorityCommand,
        CreatePriorityDto, UpdatePriorityDto,
        GetPriorityDetailsQuery, GetPriorityListQuery,
        PriorityDto>
    {
        public PriorityController(IMediator mediator)
            : base(mediator)
        {
        }
    }
}
