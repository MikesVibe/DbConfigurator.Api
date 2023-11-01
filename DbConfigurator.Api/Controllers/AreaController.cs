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
    public class AreaController : AuthorizingController
    {
        private readonly IMediator _mediator;

        public AreaController(IMediator mediator)
        {
            _mediator = mediator;
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
            var area = await _mediator.Send(new GetAreaDetailsQuery() { AreaId = id });
            if (area.IsFailed)
                return BadRequest(area.Errors.Single());

            return Ok(area.Value);
        }

        [HttpPost(Name = "AddArea")]
        public async Task<IActionResult> AddArea([FromBody] CreateAreaDto area)
        {
            var response = await _mediator.Send(new CreateAreaCommand() { CreateEntityDto = area });

            if (response.IsFailed)
                return BadRequest(response.Errors.Single());

            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteArea(int id)
        {
            var response = await _mediator.Send(new DeleteAreaCommand() { AreaId = id });

            if (response.IsFailed)
                return BadRequest(response.Errors.Single());

            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateArea([FromBody] UpdateAreaDto area)
        {
            var response = await _mediator.Send(new UpdateAreaCommand() { Area = area });

            if (response.IsFailed)
                return BadRequest(response.Errors.Single());

            return Ok();
        }
    }
}
