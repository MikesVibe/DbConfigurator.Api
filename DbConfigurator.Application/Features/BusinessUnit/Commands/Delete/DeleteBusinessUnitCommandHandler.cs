using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.BusinessUnitFeature
{
    public class DeleteBusinessUnitCommandHandler : IRequestHandler<DeleteBusinessUnitCommand, Result<BusinessUnitDto>>
    {
        public async Task<Result<BusinessUnitDto>> Handle(DeleteBusinessUnitCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
