using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.PriorityFeature;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RecipientFeature
{
    public class GetRecipientDetailsQueryHandler : IRequestHandler<GetRecipientDetailsQuery, Result<RecipientDto>>
    {
        private readonly IRecipientRepository _recipientRepository;
        private readonly IMapper _mapper;

        public GetRecipientDetailsQueryHandler(
            IRecipientRepository recipientRepository,
            IMapper mapper)
        {
            _recipientRepository = recipientRepository;
            _mapper = mapper;
        }

        public async Task<Result<RecipientDto>> Handle(GetRecipientDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _recipientRepository.GetByIdAsync(request.RecipientId);
            if (entity is null)
            {
                return Result.Fail("Priority with specified Id is no longer present in database.");
            }
            return _mapper.Map<RecipientDto>(entity);
        }
    }
}
