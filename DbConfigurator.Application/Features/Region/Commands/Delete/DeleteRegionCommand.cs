using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RegionFeature
{
    public class DeleteRegionCommand : IRequest<Result<RegionDto>>
    {
        public RegionDto Region { get; set; } = new RegionDto();
    }
}
