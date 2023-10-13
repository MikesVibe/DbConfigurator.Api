using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.Region;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RegionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetRegion")]
        public async Task<ActionResult<IEnumerable<RegionDto>>> GetRegion()
        {
            var region = await _mediator.Send(new GetRegionListQuery());
            return Ok(region);
        }

        [HttpGet("{regionId}", Name = "GetRegionById")]
        public async Task<ActionResult<RegionDto>> GetRegionById(int regionId)
        {
            var region = await _mediator.Send(new GetRegionDetailsQuery() { RegionId = regionId });
            return Ok(region);
        }

        [HttpPost(Name = "AddRegion")]
        public async Task<IActionResult> AddRegion([FromBody] RegionDto region)
        {
            var response = await _mediator.Send(new CreateRegionCommand() { Region = region });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteRegion([FromBody] RegionDto region)
        {
            var response = await _mediator.Send(new DeleteRegionCommand() { Region = region });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateRegion([FromBody] RegionDto region)
        {
            var response = await _mediator.Send(new UpdateRegionCommand() { Region = region });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
    }
}
