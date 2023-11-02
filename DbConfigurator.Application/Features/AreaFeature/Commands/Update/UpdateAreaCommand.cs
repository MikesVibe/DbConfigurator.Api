using DbConfigurator.Application.Contracts.Features.Update;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.AreaFeature.Commands.Update
{
    public class UpdateAreaCommand : IRequest<Result>, IUpdateCommand
    {
        public IUpdateEntityDto UpdateEntityDto { get; set; }
    }
}
