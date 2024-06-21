using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.PriorityFeature.Commands.Delete
{
    public class DeletePriorityCommandHandler : DeleteCommandHandlerBase<Priority, PriorityDto, DeletePriorityCommand>,
        IRequestHandler<DeletePriorityCommand, Result>
    {
        private readonly IPriorityRepository _priorityRepository;

        public DeletePriorityCommandHandler(
            IPriorityRepository priorityRepository)
            : base(priorityRepository)
        {
        }
    }
}
