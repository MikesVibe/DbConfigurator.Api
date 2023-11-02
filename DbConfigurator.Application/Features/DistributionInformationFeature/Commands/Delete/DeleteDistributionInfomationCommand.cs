using DbConfigurator.Application.Contracts.Features.Delete;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Delete
{
    public class DeleteDistributionInfomationCommand : IRequest<Result>, IDeleteCommand
    {
        public int Id { get; set; }
    }
}
