using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RecipientFeature
{
    public class GetRecipientListQueryHandler : IRequestHandler<GetRecipientListQuery, IEnumerable<RecipientDto>>
    {
        private readonly IRecipientRepository _recipientRepository;
        private readonly IMapper _mapper;

        public GetRecipientListQueryHandler(
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
        public async Task<IEnumerable<RecipientDto>> Handle(GetRecipientListQuery request, CancellationToken cancellationToken)
        {
            var entity = await _recipientRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<RecipientDto>>(entity);
        }
    }
}
