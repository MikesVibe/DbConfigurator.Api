using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.Feature
{
    public class CreatePriorityCommand : IRequest<Result<PriorityDto>>
    {
        public PriorityDto Priority { get; set; } = new PriorityDto();
    }
}
