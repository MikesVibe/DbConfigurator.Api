using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Update
{
    public class UpdateDistributionInformationCommandHandler : IRequestHandler<UpdateDistributionInformationCommand, Result>
    {
        private readonly IDistributionInformationRepository _distributionInformationRepository;
        private readonly IRecipientRepository _recipientRepository;
        private readonly IPriorityRepository _priorityRepository;
        private readonly IRegionRepository _regionRepository;
        private readonly IMapper _mapper;

        public UpdateDistributionInformationCommandHandler(
            IDistributionInformationRepository distributionInformationRepository,
            IRecipientRepository recipientRepository,
            IPriorityRepository priorityRepository,
            IRegionRepository regionRepository,
            IMapper mapper)
        {
            _distributionInformationRepository = distributionInformationRepository;
            _recipientRepository = recipientRepository;
            _priorityRepository = priorityRepository;
            _regionRepository = regionRepository;
            _mapper = mapper;
        }
        public async Task<Result> Handle(UpdateDistributionInformationCommand request, CancellationToken cancellationToken)
        {
            var requestDto = request.UpdateEntityDto as UpdateDistributionInformationDto;
            var entity = await _distributionInformationRepository.GetByIdAsync(requestDto.Id);
            if (entity == null)
            {
                return Result.Fail("No instance of distribution information object with specified Id is present in database.");
            }
            bool everyRecipientExists;
            everyRecipientExists = await _recipientRepository.ExistsRangeAsync(requestDto.RecipientsTo);
            if (everyRecipientExists == false)
            {
                return Result.Fail("Some recipients are no longer present in database.");
            }
            everyRecipientExists = await _recipientRepository.ExistsRangeAsync(requestDto.RecipientsCc);
            if (everyRecipientExists == false)
            {
                return Result.Fail("Some recipients are no longer present in database.");
            }
            var priorityExists = await _priorityRepository.ExistsAsync(requestDto.PriorityId);
            if (priorityExists == false)
            {
                return Result.Fail("Priority with specified Id is no longer present in database.");
            }
            var regionExists = await _regionRepository.ExistsAsync(requestDto.RegionId);
            if (regionExists == false)
            {
                return Result.Fail("Region with specified Id is no longer present in database.");
            }


            _mapper.Map(requestDto, entity);

            // Manually handle the relationships. Get real entities from database with Ids specified in request
            entity.RecipientsTo = await _recipientRepository.GetRecipientsAsync(requestDto.RecipientsTo);
            entity.RecipientsCc = await _recipientRepository.GetRecipientsAsync(requestDto.RecipientsCc);

            var result = await _distributionInformationRepository.UpdateAsync(entity);
            if (result)
            {
                return Result.Ok();
            }
            else
            {
                return Result.Fail("Update of distributionInformation failed.");
            }
        }
    }
}
