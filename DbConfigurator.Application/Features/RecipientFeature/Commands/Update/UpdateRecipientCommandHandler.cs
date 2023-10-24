using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.PriorityFeature.Commands.Update;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RecipientFeature.Commands.Update
{
    public class UpdateRecipientCommandHandler : IRequestHandler<UpdateRecipientCommand, Result<RecipientDto>>
    {
        private readonly IRecipientRepository _recipientRepository;
        private readonly IMapper _mapper;

        public UpdateRecipientCommandHandler(
            IRecipientRepository recipientRepository,
            IMapper mapper)
        {
            _recipientRepository = recipientRepository;
            _mapper = mapper;
        }

        public async Task<Result<RecipientDto>> Handle(UpdateRecipientCommand request, CancellationToken cancellationToken)
        {
            var entity = await _recipientRepository.GetByIdAsync(request.Recipient.Id);
            if (entity == null)
            {
                return Result.Fail("No istnace of recipient object with specified Id is present in database.");
            }

            _mapper.Map(request.Recipient, entity);

            await _recipientRepository.UpdateAsync(entity);
            return Result.Ok();
        }
    }
}
