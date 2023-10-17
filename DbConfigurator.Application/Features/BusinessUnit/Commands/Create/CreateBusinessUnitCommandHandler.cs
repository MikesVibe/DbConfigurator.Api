using AutoMapper;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.BusinessUnitFeature
{
    public class CreateBusinessUnitCommandHandler : IRequestHandler<CreateBusinessUnitCommand, Result<BusinessUnitDto>>
    {
        public CreateBusinessUnitCommandHandler()
        {
        }

        public async Task<Result<BusinessUnitDto>> Handle(CreateBusinessUnitCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
