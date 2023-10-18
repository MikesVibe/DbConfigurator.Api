using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.AreaFeature;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Queries.GetDetails
{
    public class GetBusinessUnitDetailsQueryHandler : IRequestHandler<GetBusinessUnitDetailsQuery, Result<BusinessUnitDto>>
    {
        private readonly IBusinessUnitRepository _businessUnitRepository;
        private readonly IMapper _mapper;

        public GetBusinessUnitDetailsQueryHandler(
            IBusinessUnitRepository businessUnitRepository,
            IMapper mapper)
        {
            _businessUnitRepository = businessUnitRepository;
            _mapper = mapper;
        }

        public async Task<Result<BusinessUnitDto>> Handle(GetBusinessUnitDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _businessUnitRepository.GetByIdAsync(request.BusinessUnitId);
            if (entity is null)
            {
                return Result.Fail("BusinessUnit with specified Id is no longer present in database.");
            }
            return _mapper.Map<BusinessUnitDto>(entity);
        }
    }
}
