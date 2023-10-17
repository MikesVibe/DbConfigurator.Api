using AutoMapper;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.RegionFeature
{
    public class CreateRegionCommandHandler : IRequestHandler<CreateRegionCommand, Result<RegionDto>>
    {
        public CreateRegionCommandHandler()
        {
        }

        public async Task<Result<RegionDto>> Handle(CreateRegionCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
