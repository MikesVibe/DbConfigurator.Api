using AutoMapper;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.Recipient
{
    public class CreateRecipientCommandHandler : IRequestHandler<CreateRecipientCommand, Result<RecipientDto>>
    {
        public CreateRecipientCommandHandler()
        {
        }

        public async Task<Result<RecipientDto>> Handle(CreateRecipientCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
