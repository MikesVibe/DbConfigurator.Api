using DbConfigurator.Aplication.Contracts.Persistence;
using DbConfigurator.Model.Entities.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Aplication.Features.DistributionInformation.Commands.Create
{
    public class CreateDistributionInformationCommandHandler : IRequestHandler<CreateDistributionInformationCommand, bool>
    {
        private readonly IDistributionInformationRepository _distributionInformationRepository;
        private readonly IRegionRepository _regionRecpository;

        public CreateDistributionInformationCommandHandler(
            IDistributionInformationRepository distributionInformationRepository,
            IRegionRepository regionRecpository)
        {
            _distributionInformationRepository = distributionInformationRepository;
            _regionRecpository = regionRecpository;
        }

        public async Task<bool> Handle(CreateDistributionInformationCommand request, CancellationToken cancellationToken)
        {
            var disInfo = request.DistributionInformation;
            var regionExists = await _regionRecpository.ExistsAsync(disInfo.Region.Id);

            return regionExists;
        }
    }
}
