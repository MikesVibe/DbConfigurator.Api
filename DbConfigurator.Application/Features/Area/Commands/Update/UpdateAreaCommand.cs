﻿using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.AreaFeature
{
    public class UpdateAreaCommand : IRequest<Result<AreaDto>>
    {
        public AreaDto Area { get; set; } = new AreaDto();
    }
}
