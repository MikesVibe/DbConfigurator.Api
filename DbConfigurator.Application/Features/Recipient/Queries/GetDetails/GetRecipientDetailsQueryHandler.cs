using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.Recipient
{
    public class GetRecipientDetailsQueryHandler : IRequestHandler<GetRecipientDetailsQuery, Result<RecipientDto>>
    {
        public async Task<Result<RecipientDto>> Handle(GetRecipientDetailsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
