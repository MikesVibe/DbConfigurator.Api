using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.BusinessUnitFeature;
using DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Create;
using DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Delete;
using DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Update;
using DbConfigurator.Application.Features.BusinessUnitFeature.Queries.GetDetails;
using DbConfigurator.Application.Features.BusinessUnitFeature.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    public class BusinessUnitController : AuthorizingController
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

        [HttpGet("{id}", Name = "GetBusinessUnitById")]
        public async Task<ActionResult<BusinessUnitDto>> GetBusinessUnitById(int id)
        {
            var businessUnit = await _mediator.Send(new GetBusinessUnitDetailsQuery() { BusinessUnitId = id });
            return Ok(businessUnit);
        }

        [HttpPost(Name = "AddBusinessUnit")]
        public async Task<IActionResult> AddBusinessUnit([FromBody] CreateBusinessUnitDto businessUnit)
        {
            var response = await _mediator.Send(new CreateBusinessUnitCommand() { CreateEntityDto = businessUnit });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBusinessUnit(int id)
        {
            var response = await _mediator.Send(new DeleteBusinessUnitCommand() { BusinessUnitId = id });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBusinessUnit([FromBody] UpdateBusinessUnitDto businessUnit)
        {
            var response = await _mediator.Send(new UpdateBusinessUnitCommand() { BusinessUnit = businessUnit });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
    }
}
