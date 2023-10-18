using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RegionFeature.Commands.Delete
{
    public class DeleteRegionCommandHandler : IRequestHandler<DeleteRegionCommand, Result<RegionDto>>
    {
        public async Task<Result<RegionDto>> Handle(DeleteRegionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
