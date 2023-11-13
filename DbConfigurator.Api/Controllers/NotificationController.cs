using DbConfigurator.Application.Features.NotificationFeature;
using DbConfigurator.Application.Features.NotificationFeature.GetList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    [Route("api/[controller]")]
    //[Authorize]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NotificationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<DistributionList>> GetDistributionList([FromBody] NotificationDataDto dataDto)
        {
            var response = await _mediator.Send(new GetDistributionListQuery() { NotificationData = dataDto });
            return Ok(response);
        }
    }
}
