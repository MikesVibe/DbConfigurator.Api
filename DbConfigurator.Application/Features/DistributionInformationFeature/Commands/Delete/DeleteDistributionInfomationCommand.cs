using DbConfigurator.Application.Contracts;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Delete
{
    public class DeleteDistributionInfomationCommand : IRequest<Result>, IDeleteCommand
    {
        public int Id { get; set; }
    }
}
