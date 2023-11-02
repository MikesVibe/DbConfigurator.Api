using DbConfigurator.Application.Contracts.Features.Update;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.PriorityFeature.Commands.Update
{
    public class UpdatePriorityCommand : IRequest<Result>, IUpdateCommand
    {
        public IUpdateEntityDto UpdateEntityDto { get; set; }
    }
}
