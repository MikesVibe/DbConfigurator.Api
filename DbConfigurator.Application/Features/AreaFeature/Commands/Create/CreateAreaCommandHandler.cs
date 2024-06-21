using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.AreaFeature.Commands.Create
{
    public class CreateAreaCommandHandler : CreateCommandHandlerBase<Area, AreaDto, CreateAreaCommand>, IRequestHandler<CreateAreaCommand, Result<AreaDto>>
    {
        public CreateAreaCommandHandler(
            IAreaRepository areaRepository,
            IMapper mapper)
            : base(areaRepository, mapper)
        {
        }
    }
}
