using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Create
{
    public class CreateDistributionInformationCommand : IRequest<Result<DistributionInformationDto>>
    {
        public CreateDistributionInformationDto DistributionInformation { get; set; } = new CreateDistributionInformationDto();
    }
}
