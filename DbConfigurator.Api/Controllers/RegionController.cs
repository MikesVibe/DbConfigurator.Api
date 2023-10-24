using DbConfigurator.Application.Dtos;
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
    public class RegionController : AuthorizingController
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
            var result = await _mediator.Send(new GetRegionDetailsQuery() { RegionId = regionId });
            if (result.IsFailed)
            {
                return BadRequest();
            }

            return Ok(result.Value);
        }

        [HttpPost(Name = "AddRegion")]
        public async Task<IActionResult> AddRegion([FromBody] CreateRegionDto region)
        {
            var response = await _mediator.Send(new CreateRegionCommand() { Region = region });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteRegion(int regionId)
        {
            var response = await _mediator.Send(new DeleteRegionCommand() { RegionId = regionId });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateRegion([FromBody] UpdateRegionDto region)
        {
            var response = await _mediator.Send(new UpdateRegionCommand() { Region = region });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
    }
}
