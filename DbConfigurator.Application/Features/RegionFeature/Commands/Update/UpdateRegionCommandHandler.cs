using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Update;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RegionFeature.Commands.Update
{
    public class UpdateRegionCommandHandler : UpdateCommandHandlerBase<Region, RegionDto, UpdateRegionCommand>,
        IRequestHandler<UpdateRegionCommand, Result>
    {
        public UpdateRegionCommandHandler(
            IRegionRepository regionRepository,
            IMapper mapper) : base(regionRepository, mapper)
        {
        }
    }
}
