using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.PriorityFeature.Commands.Update
{
    public class UpdatePriorityCommandHandler : UpdateCommandHandlerBase<Priority, PriorityDto, UpdatePriorityCommand>,
        IRequestHandler<UpdatePriorityCommand, Result>
    {
        public UpdatePriorityCommandHandler(
            IPriorityRepository priorityRepository,
            IMapper mapper) : base(priorityRepository, mapper)
        {
        }
    }
}
