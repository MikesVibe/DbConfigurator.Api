using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.PriorityFeature.Commands.Update;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RecipientFeature.Commands.Update
{
    public class UpdateRecipientCommandHandler : UpdateCommandHandlerBase<Recipient, RecipientDto, UpdateRecipientCommand>,
        IRequestHandler<UpdateRecipientCommand, Result>
    {
        public UpdateRecipientCommandHandler(
            IRecipientRepository recipientRepository,
            IMapper mapper) : base(recipientRepository, mapper)
        {
        }
    }
}
