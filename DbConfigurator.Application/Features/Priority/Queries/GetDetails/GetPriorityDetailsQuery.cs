using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.Feature
{
    public class GetPriorityDetailsQuery : IRequest<Result<PriorityDto>>
    {
        public int PriorityId { get; set; }
    }
}
