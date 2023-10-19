using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Delete;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.CountriesFeature.Commands.Delete
{
    public class DeleteCountryCommandHandler : IRequestHandler<DeleteCountryCommand, Result<CountryDto>>
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public DeleteCountryCommandHandler(
            ICountryRepository countryRepository,
            IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task<Result<CountryDto>> Handle(DeleteCountryCommand request, CancellationToken cancellationToken)
        {
            var entity = await _countryRepository.GetByIdAsync(request.CountryId);
            if (entity == null)
            {
                return Result.Fail("No instance of country object with specified Id is present in database.");
            }

            await _countryRepository.DeleteAsync(entity);
            return Result.Ok();
        }
    }
}
