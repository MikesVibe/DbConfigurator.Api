using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.CountriesFeature.Commands.Delete;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.PriorityFeature.Commands.Delete
{
    public class DeletePriorityCommandHandler : DeleteCommandHandlerBase<Priority, PriorityDto, DeletePriorityCommand>,
        IRequestHandler<DeletePriorityCommand, Result>
    {
        private readonly IPriorityRepository _priorityRepository;

        public DeletePriorityCommandHandler(
            IPriorityRepository priorityRepository)
            :base(priorityRepository)
        {
        }
    }
}
