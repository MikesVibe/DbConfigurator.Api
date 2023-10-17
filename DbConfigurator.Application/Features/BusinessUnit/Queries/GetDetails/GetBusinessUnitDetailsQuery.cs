﻿using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.BusinessUnitFeature
{
    public class GetBusinessUnitDetailsQuery : IRequest<Result<BusinessUnitDto>>
    {
        public int BusinessUnitId { get; set; }
    }
}
