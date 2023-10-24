using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RecipientFeature.Commands.Update
{
    public class UpdateRecipientCommand : IRequest<Result<RecipientDto>>
    {
        public UpdateRecipientDto Recipient { get; set; } = new UpdateRecipientDto();
    }
}
