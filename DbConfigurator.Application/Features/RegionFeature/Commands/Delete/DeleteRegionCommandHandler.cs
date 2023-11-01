using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Delete;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
