using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Model.Entities.Core;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.DistributionInformation
{
    public class CreateDistributionInformationCommandHandler : IRequestHandler<CreateDistributionInformationCommand, Result<DistributionInformationDto>>
    {
        private readonly IDistributionInformationRepository _distributionInformationRepository;
        private readonly IRegionRepository _regionRecpository;
        private readonly IMapper _mapper;

        public CreateDistributionInformationCommandHandler(
            IDistributionInformationRepository distributionInformationRepository,
            IRegionRepository regionRecpository,
            IMapper mapper)
        {
            _distributionInformationRepository = distributionInformationRepository;
            _regionRecpository = regionRecpository;
            _mapper = mapper;
        }

        public async Task<Result<DistributionInformationDto>> Handle(CreateDistributionInformationCommand request, CancellationToken cancellationToken)
        {
            var disInfo = request.DistributionInformation;
            var regionExists = await _regionRecpository.ExistsAsync(disInfo.Region.Id);
            if (regionExists == false)
                return Result.Fail("No istnace of region object with specified Id is present in database.");

            var mappedDisInfo = _mapper.Map<Api.Models.DistributionInformation>(request.DistributionInformation);

            //Returns invalid dto, in future change it to return result exception message
            if (mappedDisInfo is null)
                return Result.Fail("Failed to map DistributionInformation.");

            var createdEntity = await _distributionInformationRepository.AddAsync(mappedDisInfo);
            if (createdEntity is null)
                return Result.Fail("Failed to create DistributionInformation.");

            var result = _mapper.Map<DistributionInformationDto>(createdEntity);
            if (result is null)
                return Result.Fail("Failed to map DistributionInformation.");


            return result;
        }
    }
}
