using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.CountriesFeature.Queries.GetList
{
    public class GetCountryListQueryHandler : IRequestHandler<GetCountryListQuery, IEnumerable<CountryDto>>
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public GetCountryListQueryHandler(
            ICountryRepository countryRepository,
            IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CountryDto>> Handle(GetCountryListQuery request, CancellationToken cancellationToken)
        {
            var entity = await _countryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CountryDto>>(entity);
        }
    }
}
