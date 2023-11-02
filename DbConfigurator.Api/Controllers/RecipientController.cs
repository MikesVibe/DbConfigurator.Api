using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.PriorityFeature.Commands.Create;
using DbConfigurator.Application.Features.PriorityFeature.Commands.Delete;
using DbConfigurator.Application.Features.PriorityFeature.Commands.Update;
using DbConfigurator.Application.Features.PriorityFeature.Queries.GetDetails;
using DbConfigurator.Application.Features.PriorityFeature.Queries.GetList;
using DbConfigurator.Application.Features.RecipientFeature;
using DbConfigurator.Application.Features.RecipientFeature.Commands.Create;
using DbConfigurator.Application.Features.RecipientFeature.Commands.Delete;
using DbConfigurator.Application.Features.RecipientFeature.Commands.Update;
using DbConfigurator.Application.Features.RecipientFeature.Queries.GetDetails;
using DbConfigurator.Application.Features.RecipientFeature.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DbConfigurator.Api.Controllers
{
    public class RecipientController : GenericController<
        CreateRecipientCommand, UpdateRecipientCommand, DeleteRecipientCommand,
        CreateRecipientDto, UpdateRecipientDto,
        GetRecipientDetailsQuery, GetRecipientListQuery,
        RecipientDto>
    {
        public RecipientController(IMediator mediator) 
            : base(mediator) 
        {
        }
    }
}
