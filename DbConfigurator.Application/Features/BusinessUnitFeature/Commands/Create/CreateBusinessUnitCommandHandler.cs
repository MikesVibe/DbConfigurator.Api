using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Create
{
    public class CreateBusinessUnitCommandHandler : IRequestHandler<CreateBusinessUnitCommand, Result<BusinessUnitDto>>
    {
        private readonly IBusinessUnitRepository _businessUnitRepository;
        private readonly IMapper _mapper;

        public CreateBusinessUnitCommandHandler(
            IBusinessUnitRepository businessUnitRepository,
            IMapper mapper)
        {
            _businessUnitRepository = businessUnitRepository;
            _mapper = mapper;
        }

        public async Task<Result<BusinessUnitDto>> Handle(CreateBusinessUnitCommand request, CancellationToken cancellationToken)
        {
            var entityToAdd = _mapper.Map<BusinessUnit>(request.BusinessUnit);
            var createdEntity = await _businessUnitRepository.AddAsync(entityToAdd);
            if (createdEntity is null)
                return Result.Fail("Failed to create BusinessUnit.");

            var result = _mapper.Map<BusinessUnitDto>(createdEntity);
            return result;
        }
    }
}
