using DbConfigurator.Application.Contracts.Features.GetList;
using DbConfigurator.Application.Dtos;
using MediatR;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Queries.GetList
{
    public class GetBusinessUnitListQuery : IRequest<IEnumerable<BusinessUnitDto>>, IGetListQuery
    {
    }
}
