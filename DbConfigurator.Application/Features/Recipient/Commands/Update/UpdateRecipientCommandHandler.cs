using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RecipientFeature
{
    public class UpdateRecipientCommandHandler : IRequestHandler<UpdateRecipientCommand, Result<RecipientDto>>
    {
        public async Task<Result<RecipientDto>> Handle(UpdateRecipientCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
