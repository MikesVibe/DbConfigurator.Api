using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.PriorityFeature.Commands.Delete;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RecipientFeature.Commands.Delete
{
    public class DeleteRecipientCommandHandler : DeleteCommandHandlerBase<Recipient, RecipientDto, DeleteRecipientCommand>,
        IRequestHandler<DeleteRecipientCommand, Result>
    {
        public DeleteRecipientCommandHandler(
            IRecipientRepository recipientRepository) 
            : base(recipientRepository)
        {
        }
    }
}
