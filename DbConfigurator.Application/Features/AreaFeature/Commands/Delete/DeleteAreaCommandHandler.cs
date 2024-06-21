using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.AreaFeature.Commands.Delete
{
    public class DeleteAreaCommandHandler : DeleteCommandHandlerBase<Area, AreaDto, DeleteAreaCommand>,
        IRequestHandler<DeleteAreaCommand, Result>
    {
        public DeleteAreaCommandHandler(
            IAreaRepository areaRepository)
            : base(areaRepository)
        {
        }
    }
}
