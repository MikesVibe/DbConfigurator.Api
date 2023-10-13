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
    public class UpdateRecipientCommand : IRequest<Result<RecipientDto>>
    {
        public RecipientDto Recipient { get; set; } = new RecipientDto();
    }
}
