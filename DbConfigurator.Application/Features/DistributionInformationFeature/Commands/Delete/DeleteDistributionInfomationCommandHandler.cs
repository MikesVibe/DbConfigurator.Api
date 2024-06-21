using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Delete
{
    public class DeleteDistributionInfomationCommandHandler : DeleteCommandHandlerBase<
        DistributionInformation,
        DistributionInformationDto,
        DeleteDistributionInfomationCommand>,
        IRequestHandler<DeleteDistributionInfomationCommand, Result>
    {
        public DeleteDistributionInfomationCommandHandler(
            IDistributionInformationRepository distributionInformationRepository)
            : base(distributionInformationRepository)
        {
        }
    }
}
