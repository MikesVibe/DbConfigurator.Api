using DbConfigurator.Application.Contracts.Features.Create;
using DbConfigurator.Application.Contracts.Features.Delete;
using DbConfigurator.Application.Contracts.Features.GetDetail;
using DbConfigurator.Application.Contracts.Features.GetList;
using DbConfigurator.Application.Contracts.Features.Update;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class GenericController<
        TCreateCommand, TUpdateCommand, TDeleteCommand,
        TCreateDto, TUpdateDto,
        TGetDetailsQuery, TGetListQuery, 
        TEntiyDto> : ControllerBase
        where TCreateCommand : ICreateCommand, IRequest<Result<TEntiyDto>>, new()
        where TUpdateCommand : IUpdateCommand, IRequest<Result>, new()
        where TDeleteCommand : IDeleteCommand, IRequest<Result>, new()
        where TGetDetailsQuery : IGetDetailQuery, IRequest<Result<TEntiyDto>>, new()
        where TGetListQuery : IGetListQuery, IRequest<IEnumerable<TEntiyDto>>, new()
        where TCreateDto : ICreateEntityDto
        where TUpdateDto : IUpdateEntityDto

    {
        protected readonly IMediator _mediator;

        public GenericController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] TCreateDto createDto)
        {
            var response = await _mediator.Send(new TCreateCommand() { CreateEntityDto = createDto });

            if (response.IsFailed)
                return BadRequest(response.Errors.Single());

            return Ok(response.Value);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id
            )
        {
            var response = await _mediator.Send(new TDeleteCommand() { Id = id });

            if (response.IsFailed)
                return BadRequest(response.Errors.Single());

            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] TUpdateDto updateDto)
        {
            var response = await _mediator.Send(new TUpdateCommand() { UpdateEntityDto = updateDto });

            if (response.IsFailed)
                return BadRequest(response.Errors.Single());

            return Ok();
        }
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<TEntiyDto>>> Get()
        {
            var response = await _mediator.Send(new TGetListQuery());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TEntiyDto>> GetById(int id)
        {
            var result = await _mediator.Send(new TGetDetailsQuery() { Id = id });
            if (result.IsFailed)
                return BadRequest(result.Errors.Single());

            return Ok(result.Value);
        }
    }
}