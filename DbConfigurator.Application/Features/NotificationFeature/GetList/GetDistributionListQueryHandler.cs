using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using MediatR;

namespace DbConfigurator.Application.Features.NotificationFeature.GetList
{
    public class GetDistributionListQueryHandler
        : IRequestHandler<GetDistributionListQuery, DistributionListDto>
    {
        private readonly IDistributionInformationRepository _disInfoRepository;
        private readonly IMapper _mapper;

        public GetDistributionListQueryHandler(
            IDistributionInformationRepository disInfoRepository,
            IMapper mapper)
        {
            _disInfoRepository = disInfoRepository;
            _mapper = mapper;
        }

        public async Task<DistributionListDto> Handle(GetDistributionListQuery request, CancellationToken cancellationToken)
        {
            var test = await _disInfoRepository.GetDistributionListBySingleName(request.NotificationData);
            var recipientsTo = _mapper.Map<IEnumerable<RecipientDto>>(test.Item1);
            var recipientsCc = _mapper.Map<IEnumerable<RecipientDto>>(test.Item2);

            return new DistributionListDto() { RecipientsTo = recipientsTo, RecipientsCc = recipientsCc };
        }
    }
}
