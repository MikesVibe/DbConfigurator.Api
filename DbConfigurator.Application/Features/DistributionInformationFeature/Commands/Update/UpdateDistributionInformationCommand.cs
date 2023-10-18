using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Update
{
    public class UpdateDistributionInformationCommand : IRequest<Result>
    {
        public UpdateDistributionInformationDto DistributionInformation { get; set; } = new();
    }
}
