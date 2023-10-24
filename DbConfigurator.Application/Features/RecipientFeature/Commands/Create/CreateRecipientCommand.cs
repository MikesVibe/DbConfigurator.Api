using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.RecipientFeature.Commands.Create
{
    public class CreateRecipientCommand : IRequest<Result<RecipientDto>>
    {
        public CreateRecipientDto Recipient { get; set; } = new CreateRecipientDto();
    }
}
