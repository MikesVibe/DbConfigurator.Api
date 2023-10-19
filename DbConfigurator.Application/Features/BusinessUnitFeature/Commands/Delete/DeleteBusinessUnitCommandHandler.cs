using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.AreaFeature.Commands.Delete;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Delete
{
    public class DeleteBusinessUnitCommandHandler : IRequestHandler<DeleteBusinessUnitCommand, Result<BusinessUnitDto>>
    {
        private readonly IBusinessUnitRepository _businessUnitRepository;
        private readonly IMapper _mapper;

        public DeleteBusinessUnitCommandHandler(
            IBusinessUnitRepository businessUnitRepository,
            IMapper mapper)
        {
            _businessUnitRepository = businessUnitRepository;
            _mapper = mapper;
        }

        public async Task<Result<BusinessUnitDto>> Handle(DeleteBusinessUnitCommand request, CancellationToken cancellationToken)
        {
            var entity = await _businessUnitRepository.GetByIdAsync(request.BusinessUnitId);
            if (entity == null)
            {
                return Result.Fail("No instance of business unit object with specified Id is present in database.");
            }

            await _businessUnitRepository.DeleteAsync(entity);
            return Result.Ok();
        }
    }
}
