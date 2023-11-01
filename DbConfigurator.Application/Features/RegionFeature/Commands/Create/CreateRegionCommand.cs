using DbConfigurator.Application.Contracts;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.RegionFeature.Commands.Create
{
    public class CreateRegionCommand : IRequest<Result<RegionDto>>, ICreateCommand
    {
        public ICreateEntityDto CreateEntityDto { get; set; }
    }
}
