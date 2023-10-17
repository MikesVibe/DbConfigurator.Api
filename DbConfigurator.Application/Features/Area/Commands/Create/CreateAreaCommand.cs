﻿using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.AreaFeature
{
    public class CreateAreaCommand : IRequest<Result<AreaDto>>
    {
        public CreateAreaDto Area { get; set; } = new CreateAreaDto();
    }
}
