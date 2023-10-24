using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.DistributionInformationFeature;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Create;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Delete;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Update;
using DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationDetails;
using DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    public class DistributionInformationController : AuthorizingController
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
        public async Task<IActionResult> DeleteDistributionInformation(int disInfoId)
        {
            var response = await _mediator.Send(new DeleteDistributionInfomationCommand() { DistributionInformationId = disInfoId });

            if (response.IsFailed)
                return BadRequest(response.Errors.FirstOrDefault());

            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDistributionInformation([FromBody] UpdateDistributionInformationDto distributionInformation)
        {
            var response = await _mediator.Send(new UpdateDistributionInformationCommand() { DistributionInformation = distributionInformation });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
    }
}
