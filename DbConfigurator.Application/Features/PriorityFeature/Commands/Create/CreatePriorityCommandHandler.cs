using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Create;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.PriorityFeature.Commands.Create
{
    public class CreatePriorityCommandHandler : IRequestHandler<CreatePriorityCommand, Result<PriorityDto>>
    {
        private readonly IPriorityRepository _priorityRepository;
        private readonly IMapper _mapper;

        public CreatePriorityCommandHandler(
            IPriorityRepository priorityRepository,
            IMapper mapper)
        {
            _priorityRepository = priorityRepository;
            _mapper = mapper;
        }

        public async Task<Result<PriorityDto>> Handle(CreatePriorityCommand request, CancellationToken cancellationToken)
        {
            var entityToAdd = _mapper.Map<Priority>(request.Priority);
            var createdEntity = await _priorityRepository.AddAsync(entityToAdd);
            if (createdEntity is null)
                return Result.Fail("Failed to create Priority.");

            var result = _mapper.Map<PriorityDto>(createdEntity);
            return Result.Ok(result);
        }
    }
}
