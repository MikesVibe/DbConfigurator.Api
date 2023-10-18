using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Create
{
    public class CreateBusinessUnitCommand : IRequest<Result<BusinessUnitDto>>
    {
        public CreateBusinessUnitDto BusinessUnit { get; set; } = new CreateBusinessUnitDto();
    }
}
