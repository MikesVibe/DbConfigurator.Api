using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformation
{
    public class CreateDistributionInformationCommand : IRequest<Result<DistributionInformationDto>>
    {
        public DistributionInformationDto DistributionInformation { get; set; } = new DistributionInformationDto();
    }
}
