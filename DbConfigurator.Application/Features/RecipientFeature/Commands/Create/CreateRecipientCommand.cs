﻿using DbConfigurator.Application.Contracts;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.RecipientFeature.Commands.Create
{
    public class CreateRecipientCommand : IRequest<Result<RecipientDto>>, ICreateCommand
    {
        public ICreateEntityDto CreateEntityDto { get; set; }
    }
}
