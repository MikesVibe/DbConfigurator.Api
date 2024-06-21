using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.RecipientFeature.Commands.Create
{
    public class CreateRecipientCommandHandler : CreateCommandHandlerBase<Recipient, RecipientDto, CreateRecipientCommand>,
        IRequestHandler<CreateRecipientCommand, Result<RecipientDto>>
    {
        public CreateRecipientCommandHandler(
            IRecipientRepository recipientRepository,
            IMapper mapper) : base(recipientRepository, mapper)
        {
        }
    }
}
