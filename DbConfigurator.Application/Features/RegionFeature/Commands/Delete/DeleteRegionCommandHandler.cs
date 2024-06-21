using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.RegionFeature.Commands.Delete
{
    public class DeleteRegionCommandHandler : DeleteCommandHandlerBase<Region, RegionDto, DeleteRegionCommand>,
        IRequestHandler<DeleteRegionCommand, Result>
    {
        public DeleteRegionCommandHandler(IRegionRepository regionRepository)
            : base(regionRepository)
        {
        }
    }
}
