using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.PriorityFeature.Commands.Create
{
    public class CreatePriorityCommand : IRequest<Result<PriorityDto>>
    {
        public CreatePriorityDto Priority { get; set; } = new CreatePriorityDto();
    }
}
