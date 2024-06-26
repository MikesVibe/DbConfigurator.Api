﻿using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.PriorityFeature.Queries.GetDetails
{
    public class GetPriorityDetailsQueryHandler : GetDetailQueryHandlerBase<Priority, PriorityDto, GetPriorityDetailsQuery>,
        IRequestHandler<GetPriorityDetailsQuery, Result<PriorityDto>>
    {
        public GetPriorityDetailsQueryHandler(
            IPriorityRepository priorityRepository,
            IMapper mapper) : base(priorityRepository, mapper)
        {
        }
    }
}
