using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.AreaFeature.Commands.Create;
using DbConfigurator.Application.Features.AreaFeature.Commands.Delete;
using DbConfigurator.Application.Features.AreaFeature.Commands.Update;
using DbConfigurator.Application.Features.AreaFeature.Queries.GetAreaDetails;
using DbConfigurator.Application.Features.AreaFeature.Queries.GetAreaList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    [ApiController]
    //[Authorize]
    [Route("api/[controller]")]
    public class AreaController : GenericController<
        CreateAreaCommand, UpdateAreaCommand, DeleteAreaCommand,
        CreateAreaDto, UpdateAreaDto,
        AreaDto>
    {
        public AreaController(IMediator mediator)
            : base(mediator)
        {
        }

        [HttpGet("all", Name = "GetArea")]
        public async Task<ActionResult<IEnumerable<AreaDto>>> GetArea()
        {
            var Area = await _mediator.Send(new GetAreaItemListQuery());
            return Ok(Area);
        }

        [HttpGet("{id}", Name = "GetAreaById")]
        public async Task<ActionResult<AreaDto>> GetAreaById(int id)
        {
            var area = await _mediator.Send(new GetAreaDetailsQuery() { Id = id });
            if (area.IsFailed)
                return BadRequest(area.Errors.Single());

            return Ok(area.Value);
        }
    }
}
