using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Update;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.PriorityFeature.Commands.Update
{
    public class UpdatePriorityCommandHandler : IRequestHandler<UpdatePriorityCommand, Result<PriorityDto>>
    {
        private readonly IPriorityRepository _priorityRepository;
        private readonly IMapper _mapper;

        public UpdatePriorityCommandHandler(
            IPriorityRepository priorityRepository,
            IMapper mapper)
        {
            _priorityRepository = priorityRepository;
            _mapper = mapper;
        }

        public async Task<Result<PriorityDto>> Handle(UpdatePriorityCommand request, CancellationToken cancellationToken)
        {
            var entity = await _priorityRepository.GetByIdAsync(request.Priority.Id);
            if (entity == null)
            {
                return Result.Fail("No istnace of priority object with specified Id is present in database.");
            }

            _mapper.Map(request.Priority, entity);

            await _priorityRepository.UpdateAsync(entity);
            return Result.Ok();
        }
    }
}
