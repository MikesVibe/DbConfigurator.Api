using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.Region
{
    public class CreateRegionCommand : IRequest<Result<RegionDto>>
    {
        public RegionDto Region { get; set; } = new RegionDto();
    }
}
