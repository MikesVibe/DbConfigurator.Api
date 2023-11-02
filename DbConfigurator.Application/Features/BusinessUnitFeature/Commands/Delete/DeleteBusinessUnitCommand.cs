﻿using DbConfigurator.Application.Contracts.Features.Delete;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Delete
{
    public class DeleteBusinessUnitCommand : IRequest<Result>, IDeleteCommand
    {
        public int Id { get; set; } 
    }
}
