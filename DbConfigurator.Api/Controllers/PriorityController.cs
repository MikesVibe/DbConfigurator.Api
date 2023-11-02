using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.PriorityFeature;
using DbConfigurator.Application.Features.PriorityFeature.Commands.Create;
using DbConfigurator.Application.Features.PriorityFeature.Commands.Delete;
using DbConfigurator.Application.Features.PriorityFeature.Commands.Update;
using DbConfigurator.Application.Features.PriorityFeature.Queries.GetDetails;
using DbConfigurator.Application.Features.PriorityFeature.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    public class PriorityController : AuthorizingController
    {
        private readonly IMediator _mediator;

        public PriorityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetPriority")]
        public async Task<ActionResult<IEnumerable<PriorityDto>>> GetPriority()
        {
            var priority = await _mediator.Send(new GetPriorityListQuery());
            return Ok(priority);
        }

        [HttpGet("{id}", Name = "GetPriorityById")]
        public async Task<ActionResult<PriorityDto>> GetPriorityById(int id)
        {
            var result = await _mediator.Send(new GetPriorityDetailsQuery() { Id = id });
            if(result.IsFailed)
                return BadRequest();

            return Ok(result.Value);
        }

        [HttpPost(Name = "AddPriority")]
        public async Task<IActionResult> AddPriority([FromBody] CreatePriorityDto priority)
        {
            var response = await _mediator.Send(new CreatePriorityCommand() { CreateEntityDto = priority });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeletePriority(int id)
        {
            var response = await _mediator.Send(new DeletePriorityCommand() { Id = id });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePriority([FromBody] UpdatePriorityDto priority)
        {
            var response = await _mediator.Send(new UpdatePriorityCommand() { UpdateEntityDto = priority });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
    }
}
