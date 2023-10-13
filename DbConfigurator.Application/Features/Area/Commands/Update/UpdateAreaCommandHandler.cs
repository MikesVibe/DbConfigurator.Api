﻿using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.Area
{
    public class UpdateAreaCommandHandler : IRequestHandler<UpdateAreaCommand, Result<AreaDto>>
    {
        public async Task<Result<AreaDto>> Handle(UpdateAreaCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
