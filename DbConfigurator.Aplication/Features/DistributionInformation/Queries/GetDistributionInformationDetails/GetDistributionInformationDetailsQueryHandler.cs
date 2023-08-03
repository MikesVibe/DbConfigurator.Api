using AutoMapper;
using DbConfigurator.Aplication.Contracts.Persistence;
using DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformationList;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformationDetails
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
