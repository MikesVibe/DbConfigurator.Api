using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.AreaFeature.Commands.Update;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Update
{
    public class UpdateBusinessUnitCommandHandler : IRequestHandler<UpdateBusinessUnitCommand, Result<BusinessUnitDto>>
    {
        private readonly IBusinessUnitRepository _businessUnitRepository;
        private readonly IMapper _mapper;

        public UpdateBusinessUnitCommandHandler(
            IBusinessUnitRepository businessUnitRepository,
            IMapper mapper)
        {
            _businessUnitRepository = businessUnitRepository;
            _mapper = mapper;
        }

        public async Task<Result<BusinessUnitDto>> Handle(UpdateBusinessUnitCommand request, CancellationToken cancellationToken)
        {
            var entity = await _businessUnitRepository.GetByIdAsync(request.BusinessUnit.Id);
            if (entity == null)
            {
                return Result.Fail("No istnace of business unit object with specified Id is present in database.");
            }

            _mapper.Map(request.BusinessUnit.Id, entity);

            await _businessUnitRepository.UpdateAsync(entity);
            return Result.Ok();
        }
    }
}
