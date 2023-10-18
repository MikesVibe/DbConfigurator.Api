using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationList
{
    public class GetDistributionInformationItemListQueryHandler :
        IRequestHandler<GetDistributionInformationItemListQuery, IEnumerable<DistributionInformationItem>>
    {
        private readonly IDistributionInformationRepository _repository;
        private readonly IMapper _mapper;

        public GetDistributionInformationItemListQueryHandler(
            IDistributionInformationRepository distributionInformationRepository,
            IMapper mapper)
        {
            _repository = distributionInformationRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DistributionInformationItem>> Handle(GetDistributionInformationItemListQuery request, CancellationToken cancellationToken)
        {
            var list = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<DistributionInformationItem>>(list);
        }


    }
}
