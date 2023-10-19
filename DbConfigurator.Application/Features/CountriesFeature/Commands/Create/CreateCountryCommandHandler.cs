using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Create;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.CountriesFeature.Commands.Create
{
    public class CreateCountryCommandHandler : IRequestHandler<CreateCountryCommand, Result<CountryDto>>
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public CreateCountryCommandHandler(
            ICountryRepository countryRepository,
            IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }


        public async Task<Result<CountryDto>> Handle(CreateCountryCommand request, CancellationToken cancellationToken)
        {
            var entityToAdd = _mapper.Map<Country>(request.Country);
            var createdEntity = await _countryRepository.AddAsync(entityToAdd);
            if (createdEntity is null)
                return Result.Fail("Failed to create Country.");

            var result = _mapper.Map<CountryDto>(createdEntity);
            return result;
        }
    }
}
