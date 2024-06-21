using DbConfigurator.Application.Contracts.Features.GetDetail;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationDetails
{
    public class GetDistributionInformationDetailsQuery : IRequest<Result<DistributionInformationDto>>, IGetDetailQuery
    {
        public int Id { get; set; }
    }
}
