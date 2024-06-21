using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using MediatR;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Queries.GetList
{
    public class GetBusinessUnitListQueryHandler : GetListQueryHandlerBase<BusinessUnit, BusinessUnitDto, GetBusinessUnitListQuery>,
        IRequestHandler<GetBusinessUnitListQuery, IEnumerable<BusinessUnitDto>>
    {
        public GetBusinessUnitListQueryHandler(
            IBusinessUnitRepository businessUnitRepository,
            IMapper mapper) : base(businessUnitRepository, mapper)
        {
        }
    }
}
