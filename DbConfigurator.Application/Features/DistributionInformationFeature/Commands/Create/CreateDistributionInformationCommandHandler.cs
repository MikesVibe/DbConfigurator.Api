using AutoMapper;
using DbConfigurator.Api.Services;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Create
{
    public class CreateDistributionInformationCommandHandler : IRequestHandler<CreateDistributionInformationCommand, Result<DistributionInformationDto>>
    {
        private readonly IDistributionInformationRepository _distributionInformationRepository;
        private readonly IPriorityRepository _priorityRepository;
        private readonly IRegionRepository _regionRecpository;
        private readonly IRecipientRepository _recipientRepository;
        private readonly IPriorityRepository _priorityRecpository;
        private readonly IMapper _mapper;

        public CreateDistributionInformationCommandHandler(
            IDistributionInformationRepository distributionInformationRepository,
            IPriorityRepository priorityRepository,
            IRegionRepository regionRecpository,
            IRecipientRepository recipientRepository,
            IMapper mapper)
        {
            _distributionInformationRepository = distributionInformationRepository;
            _priorityRepository = priorityRepository;
            _regionRecpository = regionRecpository;
            _recipientRepository = recipientRepository;
            _mapper = mapper;
        }

        public async Task<Result<DistributionInformationDto>> Handle(CreateDistributionInformationCommand request, CancellationToken cancellationToken)
        {
            var disInfo = request.DistributionInformation;
            var regionExists = await _regionRecpository.ExistsAsync(disInfo.RegionId);
            if (regionExists == false)
            {
                return Result.Fail("No istnace of region object with specified Id is present in database.");
            }

            var priorityExists = await _priorityRepository.ExistsAsync(disInfo.PriorityId);
            if (priorityExists == false)
            {
                return Result.Fail("No istnace of priority object with specified Id is present in database.");
            }

            var entity = _mapper.Map<DistributionInformation>(request.DistributionInformation);
            // Manually handle the relationships. Get real entities from database with Ids specified in request
            entity.RecipientsTo = await _recipientRepository.GetRecipientsAsync(request.DistributionInformation.RecipientsTo);
            entity.RecipientsCc = await _recipientRepository.GetRecipientsAsync(request.DistributionInformation.RecipientsCc);

            var result = await _distributionInformationRepository.AddAsync(entity);
            if (result.IsFailed)
            {
                return Result.Fail("Failed to create DistributionInformation.");
            }

            var dto = _mapper.Map<DistributionInformationDto>(result);

            return dto;
        }
    }
}
