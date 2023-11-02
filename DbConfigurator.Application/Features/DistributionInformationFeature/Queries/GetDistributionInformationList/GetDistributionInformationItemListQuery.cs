using DbConfigurator.Application.Contracts.Features.GetList;
using DbConfigurator.Application.Dtos;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationList
{
    public class GetDistributionInformationItemListQuery : IRequest<IEnumerable<DistributionInformationDto>>, IGetListQuery
    {
    }
}
