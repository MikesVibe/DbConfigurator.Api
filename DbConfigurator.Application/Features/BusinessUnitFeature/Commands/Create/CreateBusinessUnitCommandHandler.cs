using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Create
{
    public class CreateBusinessUnitCommandHandler : CreateCommandHandlerBase<BusinessUnit, BusinessUnitDto, CreateBusinessUnitCommand>,
        IRequestHandler<CreateBusinessUnitCommand, Result<BusinessUnitDto>>
    {
        public CreateBusinessUnitCommandHandler(
            IBusinessUnitRepository businessUnitRepository,
            IMapper mapper) : base(businessUnitRepository, mapper)
        {
        }
    }
}
