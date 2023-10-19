using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Delete;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.PriorityFeature.Commands.Delete
{
    public class DeletePriorityCommandHandler : IRequestHandler<DeletePriorityCommand, Result<PriorityDto>>
    {
        private readonly IPriorityRepository _priorityRepository;
        private readonly IMapper _mapper;

        public DeletePriorityCommandHandler(
            IPriorityRepository priorityRepository,
            IMapper mapper)
        {
            _priorityRepository = priorityRepository;
            _mapper = mapper;
        }

        public async Task<Result<PriorityDto>> Handle(DeletePriorityCommand request, CancellationToken cancellationToken)
        {
            var entity = await _priorityRepository.GetByIdAsync(request.PriorityId);
            if (entity == null)
            {
                return Result.Fail("No instance of priority object with specified Id is present in database.");
            }

            await _priorityRepository.DeleteAsync(entity);
            return Result.Ok();
        }
    }
}
