using DbConfigurator.Application.Contracts.Features.Delete;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.CountriesFeature.Commands.Delete
{
    public class DeleteCountryCommand : IRequest<Result>, IDeleteCommand
    {
        public int Id { get; set; }
    }
}
