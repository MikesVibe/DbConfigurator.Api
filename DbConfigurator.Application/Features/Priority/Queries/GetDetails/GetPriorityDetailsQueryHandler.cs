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
    public class GetPriorityDetailsQueryHandler : IRequestHandler<GetPriorityDetailsQuery, Result<PriorityDto>>
    {
        private readonly IPriorityRepository _priorityRepository;
        private readonly IMapper _mapper;

        public GetPriorityDetailsQueryHandler(
            IPriorityRepository priorityRepository,
            IMapper mapper)
        {
            _priorityRepository = priorityRepository;
            _mapper = mapper;
        }

        public async Task<Result<PriorityDto>> Handle(GetPriorityDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _priorityRepository.GetByIdAsync(request.PriorityId);
            if (entity is null)
            {
                return Result.Fail("Priority with specified Id is no longer present in database.");
            }
            return _mapper.Map<PriorityDto>(entity);
        }
    }
}
