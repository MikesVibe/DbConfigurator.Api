using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RegionFeature.Queries.GetList
{
    public class GetRegionListQueryHandler : GetListQueryHandlerBase<Region, RegionDto, GetRegionListQuery>,
        IRequestHandler<GetRegionListQuery, IEnumerable<RegionDto>>
    {

        public GetRegionListQueryHandler(
            IRegionRepository regionRepository,
            IMapper mapper) : base(regionRepository, mapper) 
        {
        }
    }
}
