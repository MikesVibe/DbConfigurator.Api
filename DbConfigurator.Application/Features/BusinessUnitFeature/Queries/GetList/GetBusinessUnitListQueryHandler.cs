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

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Queries.GetList
{
    public class GetBusinessUnitListQueryHandler : IRequestHandler<GetBusinessUnitListQuery, IEnumerable<BusinessUnitDto>>
    {
        private readonly IBusinessUnitRepository _businessUnitRepository;
        private readonly IMapper _mapper;

        public GetBusinessUnitListQueryHandler(
            IBusinessUnitRepository businessUnitRepository,
            IMapper mapper)
        {
            _businessUnitRepository = businessUnitRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BusinessUnitDto>> Handle(GetBusinessUnitListQuery request, CancellationToken cancellationToken)
        {
            var entity = await _businessUnitRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<BusinessUnitDto>>(entity);
        }
    }
}
