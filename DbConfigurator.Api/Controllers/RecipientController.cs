using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.RecipientFeature.Commands.Create;
using DbConfigurator.Application.Features.RecipientFeature.Commands.Delete;
using DbConfigurator.Application.Features.RecipientFeature.Commands.Update;
using DbConfigurator.Application.Features.RecipientFeature.Queries.GetDetails;
using DbConfigurator.Application.Features.RecipientFeature.Queries.GetList;
using MediatR;

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
