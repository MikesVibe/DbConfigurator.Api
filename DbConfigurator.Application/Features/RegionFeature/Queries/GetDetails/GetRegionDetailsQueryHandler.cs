using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.PriorityFeature;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RegionFeature.Queries.GetDetails
{
    public class GetRegionDetailsQueryHandler : IRequestHandler<GetRegionDetailsQuery, Result<RegionDto>>
    {
        private readonly IRegionRepository _regionRepository;
        private readonly IMapper _mapper;

        public GetRegionDetailsQueryHandler(
            IRegionRepository regionRepository,
            IMapper mapper)
        {
            _regionRepository = regionRepository;
            _mapper = mapper;
        }

        public async Task<Result<RegionDto>> Handle(GetRegionDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _regionRepository.GetByIdAsync(request.RegionId);
            if (entity is null)
            {
                return Result.Fail("Region with specified Id is no longer present in database.");
            }
            return _mapper.Map<RegionDto>(entity);
        }
    }
}
