using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.AreaFeature.Commands.Create
{
    public class CreateAreaCommandHandler : IRequestHandler<CreateAreaCommand, Result<AreaDto>>
    {
        private readonly IAreaRepository _areaRepository;
        private readonly IMapper _mapper;

        public CreateAreaCommandHandler(
            IAreaRepository areaRepository,
            IMapper mapper)
        {
            _areaRepository = areaRepository;
            _mapper = mapper;
        }

        public async Task<Result<AreaDto>> Handle(CreateAreaCommand request, CancellationToken cancellationToken)
        {
            var entityToAdd = _mapper.Map<Domain.Model.Entities.Area>(request.Area);
            var createdEntity = await _areaRepository.AddAsync(entityToAdd);
            if (createdEntity is null)
                return Result.Fail("Failed to create Area.");

            var result = _mapper.Map<AreaDto>(createdEntity);
            return result;
        }
    }
}
