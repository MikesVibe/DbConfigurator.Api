using DbConfigurator.Application.Contracts.Features.Delete;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.RecipientFeature.Commands.Delete
{
    public class DeleteRecipientCommand : IRequest<Result>, IDeleteCommand
    {
        public int Id { get; set; }
    }
}
