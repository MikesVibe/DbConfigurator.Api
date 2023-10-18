using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.BusinessUnitFeature;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.CountriesFeature.Queries.GetDetails
{
    public class GetCountryDetailsQueryHandler : IRequestHandler<GetCountryDetailsQuery, Result<CountryDto>>
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public GetCountryDetailsQueryHandler(
            ICountryRepository countryRepository,
            IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task<Result<CountryDto>> Handle(GetCountryDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _countryRepository.GetByIdAsync(request.CountryId);
            if (entity is null)
            {
                return Result.Fail("Country with specified Id is no longer present in database.");
            }
            return _mapper.Map<CountryDto>(entity);
        }
    }
}
