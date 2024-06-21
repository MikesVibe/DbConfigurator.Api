using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

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
