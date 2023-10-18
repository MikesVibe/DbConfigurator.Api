using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature
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
            var entity = await _distributionInformationRepository.GetByIdAsync(request.DistributionInformation.Id);
            if (entity == null)
            {
                return Result.Fail("No istnace of distribution information object with specified Id is present in database.");
            }
            bool everyRecipientExists;
            everyRecipientExists = await _recipientRepository.ExistsRangeAsync(request.DistributionInformation.RecipientsTo);
            if (everyRecipientExists == false)
            {
                return Result.Fail("Some recipients are no longer present in database.");
            }
            everyRecipientExists = await _recipientRepository.ExistsRangeAsync(request.DistributionInformation.RecipientsCc);
            if (everyRecipientExists == false)
            {
                return Result.Fail("Some recipients are no longer present in database.");
            }


            _mapper.Map(request.DistributionInformation, entity);
            await _distributionInformationRepository.UpdateAsync(entity);
            return Result.Ok();
        }
    }
}
