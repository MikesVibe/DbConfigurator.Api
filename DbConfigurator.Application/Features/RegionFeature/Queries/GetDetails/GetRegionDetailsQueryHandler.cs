using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.PriorityFeature;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RegionFeature.Queries.GetDetails
{
    public class GetRegionDetailsQueryHandler : GetDetailQueryHandlerBase<Region, RegionDto, GetRegionDetailsQuery>,
        IRequestHandler<GetRegionDetailsQuery, Result<RegionDto>>
    {
        public GetRegionDetailsQueryHandler(
            IRegionRepository regionRepository,
            IMapper mapper) : base(regionRepository, mapper) 
        {
        }
    }
}
