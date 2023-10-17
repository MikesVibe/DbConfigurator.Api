using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.Area
{
    public class CreateAreaCommand : IRequest<Result<AreaDto>>
    {
        public AreaCreateDto Area { get; set; } = new AreaCreateDto();
    }
}
