using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationDetails
{
    public class GetDistributionInformationDetailsQueryHandler : 
        GetDetailQueryHandlerBase<DistributionInformation, DistributionInformationDto, GetDistributionInformationDetailsQuery>,
        IRequestHandler<GetDistributionInformationDetailsQuery, Result<DistributionInformationDto>>
    {
        public GetDistributionInformationDetailsQueryHandler(
            IDistributionInformationRepository distributionInformationRepository,
            IMapper mapper) : base(distributionInformationRepository, mapper)
        {
        }
    }
}
