using DbConfigurator.Aplication.Features.DistributionInformation;
using DbConfigurator.Aplication.Features.DistributionInformation.Commands;
using DbConfigurator.Aplication.Features.DistributionInformation.Queries;
using DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformationDetails;
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

        [HttpPut(Name = "AddRecipientsTo")]
        public async Task<IActionResult> AddReciepientsTo(int disInfoId, [FromBody]IEnumerable<int> recipientIds)
        {
            Task.CompletedTask.Wait();
            await _mediator.Send(new DistributionInformationAddRecipientsToCommand(disInfoId, recipientIds));
            return Ok();
        }
    }
}
