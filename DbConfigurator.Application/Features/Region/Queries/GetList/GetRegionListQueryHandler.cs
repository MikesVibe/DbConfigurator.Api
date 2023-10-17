using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.Region
{
    public class GetRegionListQueryHandler : IRequestHandler<GetRegionListQuery, IEnumerable<RegionDto>>
    {
        private readonly IRegionRepository _regionRepository;
        private readonly IMapper _mapper;

        public GetRegionListQueryHandler(
            IRegionRepository regionRepository,
            IMapper mapper)
        {
            _regionRepository = regionRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RegionDto>> Handle(GetRegionListQuery request, CancellationToken cancellationToken)
        {
            var entity = await _regionRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<RegionDto>>(entity);
        }
    }
}
