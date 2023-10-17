using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.AreaFeature
{
    public class GetAreaDetailsQuery : IRequest<Result<AreaDto>>
    {
        public int AreaId { get; set; }
    }
}
