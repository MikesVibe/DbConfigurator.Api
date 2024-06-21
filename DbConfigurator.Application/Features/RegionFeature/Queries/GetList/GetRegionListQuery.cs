using DbConfigurator.Application.Contracts.Features.GetList;
using DbConfigurator.Application.Dtos;
using MediatR;

namespace DbConfigurator.Application.Features.RegionFeature.Queries.GetList
{
    public class GetRegionListQuery : IRequest<IEnumerable<RegionDto>>, IGetListQuery
    {
    }
}
