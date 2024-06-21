using DbConfigurator.Application.Contracts.Features.Delete;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.PriorityFeature.Commands.Delete
{
    public class DeletePriorityCommand : IRequest<Result>, IDeleteCommand
    {
        public int Id { get; set; }
    }
}
