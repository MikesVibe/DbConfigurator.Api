using DbConfigurator.Application.Contracts.Features.Create;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.AreaFeature.Commands.Create
{
    public class CreateAreaCommand : IRequest<Result<AreaDto>>, ICreateCommand
    {
        public ICreateEntityDto CreateEntityDto { get; set; }
    }
}
