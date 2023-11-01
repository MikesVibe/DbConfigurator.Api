using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.AreaFeature.Commands.Delete;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
