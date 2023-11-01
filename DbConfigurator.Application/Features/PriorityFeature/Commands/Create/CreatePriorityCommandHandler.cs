using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Create;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.PriorityFeature.Commands.Create
{
    public class CreatePriorityCommandHandler : CreateCommandHandlerBase<Priority, PriorityDto, CreatePriorityCommand>,
        IRequestHandler<CreatePriorityCommand, Result<PriorityDto>>
    {
        public CreatePriorityCommandHandler(
            IPriorityRepository priorityRepository,
            IMapper mapper) : base(priorityRepository, mapper)
        {
        }
    }
}
