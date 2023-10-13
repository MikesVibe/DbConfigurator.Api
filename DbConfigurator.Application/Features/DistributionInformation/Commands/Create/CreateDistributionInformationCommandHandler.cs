using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformation
{
    public class CreateDistributionInformationCommandHandler : IRequestHandler<CreateDistributionInformationCommand, Result<DistributionInformationDto>>
    {
        private readonly IDistributionInformationRepository _distributionInformationRepository;
        private readonly IPriorityRepository _priorityRepository;
        private readonly IRegionRepository _regionRecpository;
        private readonly IPriorityRepository _priorityRecpository;
        private readonly IMapper _mapper;

        public CreateDistributionInformationCommandHandler(
            IDistributionInformationRepository distributionInformationRepository,
            IPriorityRepository priorityRepository,
            IRegionRepository regionRecpository,
            IMapper mapper)
        {
            _distributionInformationRepository = distributionInformationRepository;
            _priorityRepository = priorityRepository;
            _regionRecpository = regionRecpository;
            _mapper = mapper;
        }

        public async Task<Result<DistributionInformationDto>> Handle(CreateDistributionInformationCommand request, CancellationToken cancellationToken)
        {
            var disInfo = request.DistributionInformation;
            var regionExists = await _regionRecpository.ExistsAsync(disInfo.Region.Id);
            if (regionExists == false)
                return Result.Fail("No istnace of region object with specified Id is present in database.");

            var priorityExists = await _priorityRepository.ExistsAsync(disInfo.Priority.Id);
            if (priorityExists == false)
                return Result.Fail("No istnace of priority object with specified Id is present in database.");

            var region = await _regionRecpository.GetByIdAsync(disInfo.Region.Id);
            var priority = await _priorityRepository.GetByIdAsync(disInfo.Priority.Id);
            var disInfoInstance = new Api.Models.DistributionInformation()
            {
                Region = region!,
                Priority = priority!
            };

            var createdEntity = await _distributionInformationRepository.AddAsync(disInfoInstance);
            if (createdEntity is null)
                return Result.Fail("Failed to create DistributionInformation.");

            var result = _mapper.Map<DistributionInformationDto>(createdEntity);

            return result;
        }
    }
}
