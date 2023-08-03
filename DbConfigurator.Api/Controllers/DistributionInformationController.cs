using DbConfigurator.Aplication.Features.DistributionInformation;
using DbConfigurator.Aplication.Features.DistributionInformation.Queries;
using DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformationList;
using DbConfigurator.Model.DTOs.Core;
using MediatR;
using Microsoft.AspNetCore.Http;
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


        [HttpGet(Name = "DistributionInformation")]
        public async Task<ActionResult<IEnumerable<DistributionInformationItem>>> GetDistributionInformation()
        {
            var distributionInformation = await _mediator.Send(new GetDistributionInformationListQuery());
            return Ok(distributionInformation);
        }

        [HttpGet(Name = "DistributionInformation")]
        public async Task<ActionResult<IEnumerable<DistributionInformationItem>>> GetDistributionInformationById()
        {
            var distributionInformation = await _mediator.Send(new GetDistributionInformationListQuery());
            return Ok(distributionInformation);
        }

        [HttpPut(Name = "DistributionInformation")]
        public async Task<IActionResult> AddReciepientsTo(int disInfoId, [FromBody]IEnumerable<int> value)
        {
            await Task.CompletedTask;
            return Ok();
        }
    }
}
