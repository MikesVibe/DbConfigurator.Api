﻿using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.BusinessUnit
{
    public class CreateBusinessUnitCommand : IRequest<Result<BusinessUnitDto>>
    {
        public BusinessUnitDto BusinessUnit { get; set; } = new BusinessUnitDto();
    }
}