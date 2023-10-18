using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.AreaFeature.Queries.GetAreaList
{
    public class GetAreaItemListQueryHandler : IRequestHandler<GetAreaItemListQuery, IEnumerable<AreaDto>>
    {
        private readonly IAreaRepository _areaRepository;
        private readonly IMapper _mapper;

        public GetAreaItemListQueryHandler(
            IAreaRepository areaRepository,
            IMapper mapper)
        {
            _areaRepository = areaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AreaDto>> Handle(GetAreaItemListQuery request, CancellationToken cancellationToken)
        {
            var areaList = await _areaRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<AreaDto>>(areaList);
        }
    }
}
