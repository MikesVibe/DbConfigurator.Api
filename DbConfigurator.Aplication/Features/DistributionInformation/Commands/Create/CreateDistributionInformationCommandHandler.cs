using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Model.Entities.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.DistributionInformation.Commands.Create
{
    public class CreateDistributionInformationCommandHandler : IRequestHandler<CreateDistributionInformationCommand, bool>
    {
        private readonly IDistributionInformationRepository _distributionInformationRepository;
        private readonly IRegionRepository _regionRecpository;
        private readonly IMapper _mapper;

        public CreateDistributionInformationCommandHandler(
            IDistributionInformationRepository distributionInformationRepository,
            IRegionRepository regionRecpository,
            IMapper mapper)
        {
            _distributionInformationRepository = distributionInformationRepository;
            _regionRecpository = regionRecpository;
            _mapper = mapper;
        }

        public async Task<bool> Handle(CreateDistributionInformationCommand request, CancellationToken cancellationToken)
        {
            var disInfo = request.DistributionInformation;
            var regionExists = await _regionRecpository.ExistsAsync(disInfo.Region.Id);

            return regionExists;
        }
    }
}
