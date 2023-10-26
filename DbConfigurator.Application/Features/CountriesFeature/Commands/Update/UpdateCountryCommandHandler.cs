using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Update;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.CountriesFeature.Commands.Update
{
    public class UpdateCountryCommandHandler : IRequestHandler<UpdateCountryCommand, Result>
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public UpdateCountryCommandHandler(
            ICountryRepository countryRepository,
            IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task<Result> Handle(UpdateCountryCommand request, CancellationToken cancellationToken)
        {
            var entity = await _countryRepository.GetByIdAsync(request.Country.Id);
            if (entity == null)
            {
                return Result.Fail("No istnace of country object with specified Id is present in database.");
            }

            _mapper.Map(request.Country, entity);

            var result = await _countryRepository.UpdateAsync(entity);
            if (result)
            {
                return Result.Ok();
            }
            else
            {
                return Result.Fail("Update of country failed.");
            }
        }
    }
}
