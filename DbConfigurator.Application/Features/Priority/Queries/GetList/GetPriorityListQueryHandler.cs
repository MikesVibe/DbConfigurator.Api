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

namespace DbConfigurator.Application.Features.PriorityFeature
{
    public class GetPriorityListQueryHandler : IRequestHandler<GetPriorityListQuery, IEnumerable<PriorityDto>>
    {
        private readonly IPriorityRepository _priorityRepository;
        private readonly IMapper _mapper;

        public GetPriorityListQueryHandler(
            IPriorityRepository priorityRepository,
            IMapper mapper)
        {
            _priorityRepository = priorityRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PriorityDto>> Handle(GetPriorityListQuery request, CancellationToken cancellationToken)
        {
            var entity = await _priorityRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<PriorityDto>>(entity);
        }
    }
}
