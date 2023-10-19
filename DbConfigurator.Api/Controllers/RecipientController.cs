﻿using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.RecipientFeature;
using DbConfigurator.Application.Features.RecipientFeature.Commands.Create;
using DbConfigurator.Application.Features.RecipientFeature.Commands.Delete;
using DbConfigurator.Application.Features.RecipientFeature.Commands.Update;
using DbConfigurator.Application.Features.RecipientFeature.Queries.GetDetails;
using DbConfigurator.Application.Features.RecipientFeature.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class RecipientController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RecipientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetRecipient")]
        public async Task<ActionResult<IEnumerable<RecipientDto>>> GetRecipient()
        {
            var recipient = await _mediator.Send(new GetRecipientListQuery());
            return Ok(recipient);
        }

        [HttpGet("{recipientId}", Name = "GetRecipientById")]
        public async Task<ActionResult<RecipientDto>> GetRecipientById(int recipientId)
        {
            var recipient = await _mediator.Send(new GetRecipientDetailsQuery() { RecipientId = recipientId });
            return Ok(recipient);
        }

        [HttpPost(Name = "AddRecipient")]
        public async Task<IActionResult> AddRecipient([FromBody] RecipientDto recipient)
        {
            var response = await _mediator.Send(new CreateRecipientCommand() { Recipient = recipient });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteRecipient([FromBody] RecipientDto recipient)
        {
            var response = await _mediator.Send(new DeleteRecipientCommand() { Recipient = recipient });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateRecipient([FromBody] RecipientDto recipient)
        {
            var response = await _mediator.Send(new UpdateRecipientCommand() { Recipient = recipient });

            if (response.IsFailed)
                return BadRequest();

            return Ok();
        }
    }
}
