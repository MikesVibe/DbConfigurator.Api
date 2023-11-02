using DbConfigurator.Application.Contracts.Features.Create;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.CountriesFeature.Commands.Create
{
    public class CreateCountryCommand : IRequest<Result<CountryDto>>, ICreateCommand
    {
        public ICreateEntityDto CreateEntityDto { get; set; }
    }
}
