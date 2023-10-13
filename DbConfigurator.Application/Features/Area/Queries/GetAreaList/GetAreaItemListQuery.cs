﻿using DbConfigurator.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.Area
{
    public class GetAreaItemListQuery : IRequest<IEnumerable<AreaDto>>
    {
    }
}