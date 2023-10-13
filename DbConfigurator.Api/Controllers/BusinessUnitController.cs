using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.BusinessUnit;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessUnitController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BusinessUnitController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetBusinessUnit")]
        public async Task<ActionResult<IEnumerable<BusinessUnitDto>>> GetBusinessUnit()
        {
            var businessUnit = await _mediator.Send(new GetBusinessUnitListQuery());
            return Ok(businessUnit);
        }

        [HttpGet("{businessUnitId}", Name = "GetBusinessUnitById")]
        public async Task<ActionResult<BusinessUnitDto>> GetBusinessUnitById(int businessUnitId)
        {
            var businessUnit = await _mediator.Send(new GetBusinessUnitDetailsQuery() { BusinessUnitId = businessUnitId });
            return Ok(businessUnit);
        }

        [HttpPost(Name = "AddBusinessUnit")]
        public async Task<IActionResult> AddBusinessUnit([FromBody] BusinessUnitDto businessUnit)
        {
            var response = await _mediator.Send(new CreateBusinessUnitCommand() { BusinessUnit = businessUnit });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBusinessUnit([FromBody] BusinessUnitDto businessUnit)
        {
            var response = await _mediator.Send(new DeleteBusinessUnitCommand() { BusinessUnit = businessUnit });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBusinessUnit([FromBody] BusinessUnitDto businessUnit)
        {
            var response = await _mediator.Send(new UpdateBusinessUnitCommand() { BusinessUnit = businessUnit });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
    }
}
