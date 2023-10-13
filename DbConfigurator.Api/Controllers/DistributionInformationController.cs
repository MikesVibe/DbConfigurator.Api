using DbConfigurator.Application.Features.DistributionInformation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributionInformationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DistributionInformationController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("all", Name = "GetDistributionInformation")]
        public async Task<ActionResult<IEnumerable<DistributionInformationItem>>> GetDistributionInformation()
        {
            var distributionInformation = await _mediator.Send(new GetDistributionInformationItemListQuery());
            return Ok(distributionInformation);
        }

        [HttpGet("{disInfoId}", Name = "GetDistributionInformationById")]
        public async Task<ActionResult<DistributionInformationItem>> GetDistributionInformationById(int disInfoId)
        {
            var distributionInformation = await _mediator.Send(new GetDistributionInformationDetailsQuery() { Id = disInfoId });
            return Ok(distributionInformation);
        }

        [HttpPost(Name = "AddDistributionInformation")]
        public async Task<IActionResult> AddDistributionInformation([FromBody] DistributionInformationDto distributionInfo)
        {
            var response = await _mediator.Send(new CreateDistributionInformationCommand() { DistributionInformation = distributionInfo });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDistributionInfomation(int disInfoId)
        {
            var response = await _mediator.Send(new DeleteDistributionInfomationCommand() { DistributionInformationId = disInfoId });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDistributionInformation([FromBody] DistributionInformationDto distributionInformation)
        {
            var response = await _mediator.Send(new UpdateDistributionInformationCommand() { DistributionInformation = distributionInformation });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
    }
}
