using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformation
{
    public class DeleteDistributionInfomationCommand : IRequest<Result<bool>>
    {
        public int DistributionInformationId { get; set; }
    }
}
