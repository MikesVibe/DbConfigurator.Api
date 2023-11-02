using DbConfigurator.Application.Contracts.Features.Update;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Update
{
    public class UpdateDistributionInformationCommand : IRequest<Result>, IUpdateCommand
    {
        public IUpdateEntityDto UpdateEntityDto { get; set; }
    }
}
