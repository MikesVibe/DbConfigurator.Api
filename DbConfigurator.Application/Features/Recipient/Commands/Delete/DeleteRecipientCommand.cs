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
    public class DeleteRecipientCommand : IRequest<Result<RecipientDto>>
    {
        public RecipientDto Recipient { get; set; } = new RecipientDto();
    }
}
