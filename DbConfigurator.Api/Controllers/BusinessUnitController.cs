using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Create;
using DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Delete;
using DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Update;
using DbConfigurator.Application.Features.BusinessUnitFeature.Queries.GetDetails;
using DbConfigurator.Application.Features.BusinessUnitFeature.Queries.GetList;
using MediatR;

namespace DbConfigurator.Api.Controllers
{
    public class BusinessUnitController : GenericController<
        CreateBusinessUnitCommand, UpdateBusinessUnitCommand, DeleteBusinessUnitCommand,
        CreateBusinessUnitDto, UpdateBusinessUnitDto,
        GetBusinessUnitDetailsQuery, GetBusinessUnitListQuery,
        BusinessUnitDto>
    {
        public BusinessUnitController(IMediator mediator)
            : base(mediator)
        {
        }
    }
}
