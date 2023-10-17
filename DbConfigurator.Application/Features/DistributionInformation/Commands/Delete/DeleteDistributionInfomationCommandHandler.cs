using DbConfigurator.Application.Contracts.Persistence;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature
{
    public class DeleteDistributionInfomationCommandHandler : IRequestHandler<DeleteDistributionInfomationCommand, Result<bool>>
    {
        private readonly IDistributionInformationRepository _distributionInformationRepository;

        public DeleteDistributionInfomationCommandHandler(
            IDistributionInformationRepository distributionInformationRepository)
        {
            _distributionInformationRepository = distributionInformationRepository;
        }
        public async Task<Result<bool>> Handle(DeleteDistributionInfomationCommand request, CancellationToken cancellationToken)
        {
            var entity = await _distributionInformationRepository.GetByIdAsync(request.DistributionInformationId);
            if (entity == null)
            {
                return Result.Fail("No istnace of distribution information object with specified Id is present in database.");
            }

            await _distributionInformationRepository.DeleteAsync(entity);

            return true;
        }
    }
}
