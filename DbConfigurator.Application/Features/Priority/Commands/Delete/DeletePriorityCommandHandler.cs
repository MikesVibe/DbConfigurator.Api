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
    public class DeletePriorityCommandHandler : IRequestHandler<DeletePriorityCommand, Result<PriorityDto>>
    {
        public async Task<Result<PriorityDto>> Handle(DeletePriorityCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
