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
    public class UpdateRegionCommandHandler : IRequestHandler<UpdateRegionCommand, Result<RegionDto>>
    {
        public async Task<Result<RegionDto>> Handle(UpdateRegionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
