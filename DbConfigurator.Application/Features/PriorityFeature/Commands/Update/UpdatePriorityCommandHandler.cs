using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.PriorityFeature.Commands.Update
{
    public class UpdatePriorityCommandHandler : IRequestHandler<UpdatePriorityCommand, Result<PriorityDto>>
    {
        public async Task<Result<PriorityDto>> Handle(UpdatePriorityCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
