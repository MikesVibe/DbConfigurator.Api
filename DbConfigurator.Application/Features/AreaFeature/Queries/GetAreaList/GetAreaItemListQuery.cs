using DbConfigurator.Application.Contracts.Features.GetList;
using DbConfigurator.Application.Dtos;
using MediatR;

namespace DbConfigurator.Application.Features.AreaFeature.Queries.GetAreaList
{
    public class GetAreaItemListQuery : IRequest<IEnumerable<AreaDto>>, IGetListQuery
    {
    }
}
