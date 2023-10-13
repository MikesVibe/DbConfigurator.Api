﻿using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.Area;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
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

        [HttpGet("{areaId}", Name = "GetAreaById")]
        public async Task<ActionResult<AreaDto>> GetAreaById(int areaId)
        {
            var Area = await _mediator.Send(new GetAreaDetailsQuery() { AreaId = areaId });
            return Ok(Area);
        }

        [HttpPost(Name = "AddArea")]
        public async Task<IActionResult> AddArea([FromBody] AreaDto area)
        {
            var response = await _mediator.Send(new CreateAreaCommand() { Area = area });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteArea([FromBody] AreaDto area)
        {
            var response = await _mediator.Send(new DeleteAreaCommand() { Area = area });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateArea([FromBody] AreaDto area)
        {
            var response = await _mediator.Send(new UpdateAreaCommand() { Area = area });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
    }
}
