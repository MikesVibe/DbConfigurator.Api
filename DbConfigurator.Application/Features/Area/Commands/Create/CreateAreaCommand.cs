using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.Area
{
    public class CreateAreaCommand : IRequest<Result<AreaDto>>
    {
        public AreaDto Area { get; set; } = new AreaDto();
    }
}
