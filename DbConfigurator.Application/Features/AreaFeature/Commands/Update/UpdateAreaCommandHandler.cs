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

namespace DbConfigurator.Application.Features.AreaFeature.Commands.Update
{
    public class UpdateAreaCommandHandler : UpdateCommandHandlerBase<Area, AreaDto, UpdateAreaCommand>,
        IRequestHandler<UpdateAreaCommand, Result>
    {
        public UpdateAreaCommandHandler(
            IAreaRepository areaRepository,
            IMapper mapper):base(areaRepository, mapper)
        {
        }
    }
}
