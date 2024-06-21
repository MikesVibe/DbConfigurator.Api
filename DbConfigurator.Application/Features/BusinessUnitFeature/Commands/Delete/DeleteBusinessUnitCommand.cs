using DbConfigurator.Application.Contracts.Features.Delete;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Delete
{
    public class DeleteBusinessUnitCommand : IRequest<Result>, IDeleteCommand
    {
        public int Id { get; set; }
    }
}
