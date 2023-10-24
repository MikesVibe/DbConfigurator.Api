using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.PriorityFeature.Commands.Delete;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RecipientFeature.Commands.Delete
{
    public class DeleteRecipientCommandHandler : IRequestHandler<DeleteRecipientCommand, Result<RecipientDto>>
    {
        private readonly IRecipientRepository _recipientRepository;
        private readonly IMapper _mapper;

        public DeleteRecipientCommandHandler(
            IRecipientRepository recipientRepository,
            IMapper mapper)
        {
            _recipientRepository = recipientRepository;
            _mapper = mapper;
        }

        public async Task<Result<RecipientDto>> Handle(DeleteRecipientCommand request, CancellationToken cancellationToken)
        {
            var entity = await _recipientRepository.GetByIdAsync(request.RecipientId);
            if (entity == null)
            {
                return Result.Fail("No instance of recipient object with specified Id is present in database.");
            }

            await _recipientRepository.DeleteAsync(entity);
            return Result.Ok();
        }
    }
}
