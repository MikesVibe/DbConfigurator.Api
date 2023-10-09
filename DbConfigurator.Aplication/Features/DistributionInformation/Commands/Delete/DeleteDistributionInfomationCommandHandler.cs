using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.DistributionInformation
{
    public class DeleteDistributionInfomationCommandHandler : IRequestHandler<DeleteDistributionInfomationCommand, Result<bool>>
    {
        public Task<Result<bool>> Handle(DeleteDistributionInfomationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
