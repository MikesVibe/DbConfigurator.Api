using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.AreaFeature.Commands.Update;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Update
{
    public class UpdateBusinessUnitCommandHandler : UpdateCommandHandlerBase<BusinessUnit, BusinessUnitDto, UpdateBusinessUnitCommand>,
        IRequestHandler<UpdateBusinessUnitCommand, Result>
    {
        public UpdateBusinessUnitCommandHandler(
            IBusinessUnitRepository businessUnitRepository,
            IMapper mapper) : base(businessUnitRepository, mapper)
        {
        }
    }
}
