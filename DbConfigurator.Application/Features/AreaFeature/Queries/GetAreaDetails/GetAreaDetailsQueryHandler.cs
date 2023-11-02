using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.AreaFeature.Queries.GetAreaDetails
{
    public class GetAreaDetailsQueryHandler : GetDetailQueryHandlerBase<Area, AreaDto, GetAreaDetailsQuery>,
        IRequestHandler<GetAreaDetailsQuery, Result<AreaDto>>
    {
        public GetAreaDetailsQueryHandler(
            IAreaRepository areaRepository,
            IMapper mapper) : base(areaRepository, mapper)
        {
        }
    }
}
