using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RegionFeature.Commands.Update
{
    public class UpdateRegionCommand : IRequest<Result<RegionDto>>
    {
        public UpdateRegionDto Region { get; set; } = new UpdateRegionDto();
    }
}
