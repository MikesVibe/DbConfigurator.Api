using DbConfigurator.Application.Contracts;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.PriorityFeature.Commands.Create
{
    public class CreatePriorityCommand : IRequest<Result<PriorityDto>>, ICreateCommand
    {
        public ICreateEntityDto CreateEntityDto { get; set; }
    }
}
