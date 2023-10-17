using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Update;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature
{
    public class UpdateDistributionInformationCommand : IRequest<Result>
    {
        public UpdateDistributionInformationDto DistributionInformation { get; set; } = new();
    }
}
