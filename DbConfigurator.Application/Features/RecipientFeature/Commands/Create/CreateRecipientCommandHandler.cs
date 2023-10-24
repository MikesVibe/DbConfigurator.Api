using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.PriorityFeature.Commands.Create;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.RecipientFeature.Commands.Create
{
    public class CreateRecipientCommandHandler : IRequestHandler<CreateRecipientCommand, Result<RecipientDto>>
    {
        private readonly IRecipientRepository _recipientRepository;
        private readonly IMapper _mapper;

        public CreateRecipientCommandHandler(
            IRecipientRepository recipientRepository,
            IMapper mapper)
        {
            _recipientRepository = recipientRepository;
            _mapper = mapper;
        }

        public async Task<Result<RecipientDto>> Handle(CreateRecipientCommand request, CancellationToken cancellationToken)
        {
            var entityToAdd = _mapper.Map<Recipient>(request.Recipient);
            var createdEntity = await _recipientRepository.AddAsync(entityToAdd);
            if (createdEntity is null)
                return Result.Fail("Failed to create Recipient.");

            var result = _mapper.Map<RecipientDto>(createdEntity);
            return Result.Ok(result);
        }
    }
}
