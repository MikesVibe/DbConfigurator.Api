using DbConfigurator.Application.Contracts.Features.Create;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Create
{
    public class CreateBusinessUnitCommand : IRequest<Result<BusinessUnitDto>>, ICreateCommand
    {
        public ICreateEntityDto CreateEntityDto { get; set; }
    }
}
