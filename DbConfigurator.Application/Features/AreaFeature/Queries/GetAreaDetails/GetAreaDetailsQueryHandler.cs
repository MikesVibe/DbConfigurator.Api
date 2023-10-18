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

namespace DbConfigurator.Application.Features.AreaFeature.Queries.GetAreaDetails
{
    public class GetAreaDetailsQueryHandler : IRequestHandler<GetAreaDetailsQuery, Result<AreaDto>>
    {
        private readonly IAreaRepository _areaRepository;
        private readonly IMapper _mapper;

        public GetAreaDetailsQueryHandler(
            IAreaRepository areaRepository,
            IMapper mapper)
        {
            _areaRepository = areaRepository;
            _mapper = mapper;
        }

        public async Task<Result<AreaDto>> Handle(GetAreaDetailsQuery request, CancellationToken cancellationToken)
        {
            var area = await _areaRepository.GetByIdAsync(request.AreaId);
            if (area is null)
            {
                return Result.Fail("Area with specified Id is no longer present in database.");
            }
            return _mapper.Map<AreaDto>(area);
        }
    }
}
