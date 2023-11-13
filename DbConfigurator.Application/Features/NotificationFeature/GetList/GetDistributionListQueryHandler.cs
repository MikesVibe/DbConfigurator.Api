using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.NotificationFeature.GetList
{
    public class GetDistributionListQueryHandler
        : IRequestHandler<GetDistributionListQuery, DistributionList>
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

        public async Task<DistributionList> Handle(GetDistributionListQuery request, CancellationToken cancellationToken)
        {
            var test = await _disInfoRepository.GetDistributionList(request.NotificationData);
            var recipientsTo = _mapper.Map<IEnumerable<RecipientDto>>(test.Item1); 
            var recipientsCc = _mapper.Map<IEnumerable<RecipientDto>>(test.Item2);

            return new DistributionList() { RecipientsTo = recipientsTo, RecipientsCc = recipientsCc };
        }
    }
}
