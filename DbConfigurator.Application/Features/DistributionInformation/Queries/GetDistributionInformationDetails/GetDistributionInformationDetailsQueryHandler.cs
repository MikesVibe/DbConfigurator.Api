using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformation
{
    public class GetDistributionInformationDetailsQueryHandler :
        IRequestHandler<GetDistributionInformationDetailsQuery, DistributionInformationItem>
    {
        private readonly IDistributionInformationRepository _repository;
        private readonly IMapper _mapper;

        public GetDistributionInformationDetailsQueryHandler(
            IDistributionInformationRepository distributionInformationRepository,
            IMapper mapper)
        {
            _repository = distributionInformationRepository;
            _mapper = mapper;
        }

        public async Task<DistributionInformationItem> Handle(GetDistributionInformationDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<DistributionInformationItem>(entity);
        }
    }
}
