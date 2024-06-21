using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Delete
{
    public class DeleteBusinessUnitCommandHandler : DeleteCommandHandlerBase<BusinessUnit, BusinessUnitDto, DeleteBusinessUnitCommand>,
        IRequestHandler<DeleteBusinessUnitCommand, Result>
    {
        public DeleteBusinessUnitCommandHandler(
            IBusinessUnitRepository businessUnitRepository)
            : base(businessUnitRepository)
        {
        }
    }
}
