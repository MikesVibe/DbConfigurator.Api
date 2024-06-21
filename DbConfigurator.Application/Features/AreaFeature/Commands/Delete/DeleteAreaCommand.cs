using DbConfigurator.Application.Contracts.Features.Delete;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.AreaFeature.Commands.Delete
{
    public class DeleteAreaCommand : IRequest<Result>, IDeleteCommand
    {
        public int Id { get; set; }
    }
}
