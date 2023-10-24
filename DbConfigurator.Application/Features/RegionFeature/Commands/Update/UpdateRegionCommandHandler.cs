using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Update;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RegionFeature.Commands.Update
{
    public class UpdateRegionCommandHandler : IRequestHandler<UpdateRegionCommand, Result<RegionDto>>
    {
        private readonly IAreaRepository _areaRepository;
        private readonly ICountryRepository _countryRepository;
        private readonly IBusinessUnitRepository _businessRepository;
        private readonly IRegionRepository _regionRepository;
        private readonly IMapper _mapper;

        public UpdateRegionCommandHandler(
            IAreaRepository areaRepository,
            ICountryRepository countryRepository,
            IBusinessUnitRepository businessRepository,
            IRegionRepository regionRepository,
            IMapper mapper)
        {
            _areaRepository = areaRepository;
            _countryRepository = countryRepository;
            _businessRepository = businessRepository;
            _regionRepository = regionRepository;
            _mapper = mapper;
        }

        public async Task<Result<RegionDto>> Handle(UpdateRegionCommand request, CancellationToken cancellationToken)
        {
            var region = request.Region;
            var regionEntity = _mapper.Map<Region>(region);


            var result = await _regionRepository.UpdateAsync(regionEntity);
            if(result == false)
            {
                return Result.Fail("Failed to update region.");
            }

            var mappedRegion = _mapper.Map<RegionDto>(regionEntity);

            return Result.Ok(mappedRegion);
        }
    }
}
