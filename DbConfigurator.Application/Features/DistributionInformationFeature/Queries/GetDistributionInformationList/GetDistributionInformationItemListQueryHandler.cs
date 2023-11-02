using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationList
{
    public class GetDistributionInformationItemListQueryHandler :
        GetListQueryHandlerBase<DistributionInformation, DistributionInformationDto, GetDistributionInformationItemListQuery>,
        IRequestHandler<GetDistributionInformationItemListQuery, IEnumerable<DistributionInformationDto>>
    {
        public GetDistributionInformationItemListQueryHandler(
            IDistributionInformationRepository distributionInformationRepository,
            IMapper mapper) : base(distributionInformationRepository, mapper)
        {
        }
    }
}
