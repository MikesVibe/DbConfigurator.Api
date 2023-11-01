using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Create;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.RegionFeature.Commands.Create
{
    public class CreateRegionCommandHandler : CreateCommandHandlerBase<Region, RegionDto, CreateRegionCommand>,
        IRequestHandler<CreateRegionCommand, Result<RegionDto>>
    {
        public CreateRegionCommandHandler(
            IRegionRepository regionRepository,
            IMapper mapper) : base(regionRepository, mapper)
        {
        }
    }
}
