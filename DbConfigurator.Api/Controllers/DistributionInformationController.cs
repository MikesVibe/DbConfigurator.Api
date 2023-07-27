using DbConfigurator.Aplication.Features.DistributionInformation;
using DbConfigurator.Aplication.Features.DistributionInformation.Queries;
using DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformation;
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


        [HttpGet(Name = "GetDistributionInformation")]
        public async Task<ActionResult<IEnumerable<DistributionInformationListItem>>> GetDistributionInformation()
        {
            var distributionInformation = await _mediator.Send(new GetDistributionInformationListItemQuery());
            return Ok(distributionInformation);
        }
    }
}
