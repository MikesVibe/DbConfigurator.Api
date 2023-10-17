using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.RecipientFeature
{
    public class CreateRecipientCommand : IRequest<Result<RecipientDto>>
    {
        public RecipientDto Recipient { get; set; } = new RecipientDto();
    }
}
