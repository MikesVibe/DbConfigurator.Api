using DbConfigurator.Application.Contracts.Features.GetList;
using DbConfigurator.Application.Dtos;
using MediatR;

namespace DbConfigurator.Application.Features.PriorityFeature.Queries.GetList
{
    public class GetPriorityListQuery : IRequest<IEnumerable<PriorityDto>>, IGetListQuery
    {
    }
}
