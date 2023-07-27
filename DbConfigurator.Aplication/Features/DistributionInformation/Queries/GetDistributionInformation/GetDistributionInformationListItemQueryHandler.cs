using AutoMapper;
using DbConfigurator.Aplication.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformation
{
    public class GetDistributionInformationListItemQueryHandler :
        IRequestHandler<GetDistributionInformationListItemQuery, IEnumerable<DistributionInformationListItem>>
    {
        private readonly IDistributionInformationRepository _repository;
        private readonly IMapper _mapper;

        public GetDistributionInformationListItemQueryHandler(
            IDistributionInformationRepository distributionInformationRepository,
            IMapper mapper)
        {
            _repository = distributionInformationRepository;
            _mapper = mapper;
        }

        async Task<IEnumerable<DistributionInformationListItem>>
            IRequestHandler<GetDistributionInformationListItemQuery,
                IEnumerable<DistributionInformationListItem>>
            .Handle(GetDistributionInformationListItemQuery request, CancellationToken cancellationToken)
        {
            var list = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<DistributionInformationListItem>>(list);
        }
    }
}
