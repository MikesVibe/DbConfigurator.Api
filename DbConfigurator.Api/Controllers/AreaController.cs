using DbConfigurator.Application.Features.Area;
using DbConfigurator.Application.Features.DistributionInformation;
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
            throw new NotImplementedException();

            //var Area = await _mediator.Send(new GetAreaItemListQuery());
            //return Ok(Area);
        }

        [HttpGet("{disInfoId}", Name = "GetAreaById")]
        public async Task<ActionResult<AreaDto>> GetAreaById(int areaId)
        {
            throw new NotImplementedException();

            //var Area = await _mediator.Send(new GetAreaDetailsQuery() { Id = disInfoId });
            //return Ok(Area);
        }

        [HttpPost(Name = "AddArea")]
        public async Task<IActionResult> AddArea([FromBody] AreaDto area)
        {
            throw new NotImplementedException();

            //var response = await _mediator.Send(new CreateAreaCommand() { Area = distributionInfo });

            //if (response.IsFailed)
            //    return BadRequest();

            //return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteArea(int areaId)
        {
            throw new NotImplementedException();

            //var response = await _mediator.Send(new DeleteDistributionInfomationCommand() { AreaId = disInfoId });

            //if (response.IsFailed)
            //    return BadRequest();

            //return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateArea([FromBody] AreaDto area)
        {
            throw new NotImplementedException();
            //var response = await _mediator.Send(new UpdateAreaCommand() { Area = Area });

            //if (response.IsFailed)
            //    return BadRequest();

            //return Ok();
        }
    }
}
