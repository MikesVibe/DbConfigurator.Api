using DbConfigurator.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.Recipient
{
    public class GetRecipientListQueryHandler : IRequestHandler<GetRecipientListQuery, IEnumerable<RecipientDto>>
    {
        public Task<IEnumerable<RecipientDto>> Handle(GetRecipientListQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
