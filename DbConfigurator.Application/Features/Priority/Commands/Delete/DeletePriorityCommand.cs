using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.PriorityFeature
{
    public class DeletePriorityCommand : IRequest<Result<PriorityDto>>
    {
        public PriorityDto Priority { get; set; } = new PriorityDto();
    }
}
