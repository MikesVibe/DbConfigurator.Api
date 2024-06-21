using DbConfigurator.Application.Contracts.Features.Delete;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.RegionFeature.Commands.Delete
{
    public class DeleteRegionCommand : IRequest<Result>, IDeleteCommand
    {
        public int Id { get; set; }
    }
}
