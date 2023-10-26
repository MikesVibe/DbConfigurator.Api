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
    public class UpdateBusinessUnitCommandHandler : IRequestHandler<UpdateBusinessUnitCommand, Result>
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

        public async Task<Result> Handle(UpdateBusinessUnitCommand request, CancellationToken cancellationToken)
        {
            var entity = await _businessUnitRepository.GetByIdAsync(request.BusinessUnit.Id);
            if (entity == null)
            {
                return Result.Fail("No istnace of business unit object with specified Id is present in database.");
            }

            _mapper.Map(request.BusinessUnit, entity);

            var result = await _businessUnitRepository.UpdateAsync(entity);
            if (result)
            {
                return Result.Ok();
            }
            else
            {
                return Result.Fail("Update of businessUnit failed.");
            }
        }
    }
}
