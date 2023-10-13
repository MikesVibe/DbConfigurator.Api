using AutoMapper;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.Area
{
    public class CreateBusinessUnitCommandHandler : IRequestHandler<CreateAreaCommand, Result<AreaDto>>
    {
        public CreateBusinessUnitCommandHandler()
        {
        }

        public async Task<Result<AreaDto>> Handle(CreateAreaCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
