using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Delete
{
    public class DeleteDistributionInfomationCommand : IRequest<Result<bool>>
    {
        public int DistributionInformationId { get; set; }
    }
}
