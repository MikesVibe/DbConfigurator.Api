﻿using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.BusinessUnit
{
    public class UpdateBusinessUnitCommandHandler : IRequestHandler<UpdateBusinessUnitCommand, Result<BusinessUnitDto>>
    {
        public async Task<Result<BusinessUnitDto>> Handle(UpdateBusinessUnitCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
