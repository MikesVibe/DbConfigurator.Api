using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.RecipientFeature.Commands.Delete
{
    public class DeleteRecipientCommandHandler : DeleteCommandHandlerBase<Recipient, RecipientDto, DeleteRecipientCommand>,
        IRequestHandler<DeleteRecipientCommand, Result>
    {
        public DeleteRecipientCommandHandler(
            IRecipientRepository recipientRepository)
            : base(recipientRepository)
        {
        }
    }
}
