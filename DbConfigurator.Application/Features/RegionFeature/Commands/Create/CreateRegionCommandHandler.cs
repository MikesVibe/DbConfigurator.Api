using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Create;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.RegionFeature.Commands.Create
{
    public class CreateRegionCommandHandler : IRequestHandler<CreateRegionCommand, Result<RegionDto>>
    {
        private readonly IAreaRepository _areaRepository;
        private readonly ICountryRepository _countryRepository;
        private readonly IBusinessUnitRepository _businessRepository;
        private readonly IRegionRepository _regionRepository;
        private readonly IMapper _mapper;

        public CreateRegionCommandHandler(
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

        public async Task<Result<RegionDto>> Handle(CreateRegionCommand request, CancellationToken cancellationToken)
        {
            var region = request.Region;
            var regionEntity = _mapper.Map<Region>(region);

            var createdEntity = await _regionRepository.AddAsync(regionEntity);
            if (createdEntity is null)
                return Result.Fail("Failed to create Region.");

            var result = _mapper.Map<RegionDto>(createdEntity);

            return Result.Ok(result);
        }
    }
}
