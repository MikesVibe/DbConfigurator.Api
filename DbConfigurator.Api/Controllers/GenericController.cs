using DbConfigurator.Application.Contracts;
using DbConfigurator.Application.Features.AreaFeature.Commands.Create;
using DbConfigurator.Application.Features.AreaFeature.Commands.Delete;
using DbConfigurator.Application.Features.AreaFeature.Commands.Update;
using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{

    public class GenericController<
        TCreateCommand, TUpdateCommand, TDeleteCommand,
        TCreateDto, TUpdateDto,
        TEntiyDto> : ControllerBase
        where TCreateCommand : ICreateCommand, IRequest<Result<TEntiyDto>>, new()
        where TUpdateCommand : IUpdateCommand, IRequest<Result>, new()
        where TDeleteCommand : IDeleteCommand, IRequest<Result>, new()
        where TCreateDto : ICreateEntityDto
        where TUpdateDto : IUpdateEntityDto

    {
        protected readonly IMediator _mediator;

        public GenericController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> AddArea([FromBody] TCreateDto createDto)
        {
            var response = await _mediator.Send(new TCreateCommand() { CreateEntityDto = createDto });

            if (response.IsFailed)
                return BadRequest(response.Errors.Single());

            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteArea(int id)
        {
            var response = await _mediator.Send(new TDeleteCommand() { Id = id });

            if (response.IsFailed)
                return BadRequest(response.Errors.Single());

            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateArea([FromBody] TUpdateDto updateDto)
        {
            var response = await _mediator.Send(new TUpdateCommand() { UpdateEntityDto = updateDto });

            if (response.IsFailed)
                return BadRequest(response.Errors.Single());

            return Ok();
        }
    }
}