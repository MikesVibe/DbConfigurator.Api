using DbConfigurator.Application.Contracts.Features.Create;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Create
{
    public class CreateDistributionInformationCommand : IRequest<Result<DistributionInformationDto>>, ICreateCommand
    {
        public ICreateEntityDto CreateEntityDto { get; set; }
    }
}
