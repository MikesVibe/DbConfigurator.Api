using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.DistributionInformationFeature;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.AreaFeature.Commands.Delete
{
    public class DeleteAreaCommandHandler : DeleteCommandHandlerBase<Area, AreaDto, DeleteAreaCommand>,
        IRequestHandler<DeleteAreaCommand, Result>
    {
        public DeleteAreaCommandHandler(
            IAreaRepository areaRepository) 
            : base(areaRepository)
        {
        }
    }
}
