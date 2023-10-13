using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformation
{
    public class UpdateDistributionInformationCommand : IRequest<Result<DistributionInformationDto>>
    {
        public DistributionInformationDto DistributionInformation { get; set; } = new DistributionInformationDto();
    }
}
