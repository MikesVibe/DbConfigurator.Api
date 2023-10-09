using DbConfigurator.Application.Contracts.Persistence;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.DistributionInformation
{
    public class UpdateDistributionInformationCommandHandler : IRequestHandler<UpdateDistributionInformationCommand, Result<DistributionInformationDto>>
    {
        private readonly IDistributionInformationRepository _distributionInformationRepository;
        private readonly IPriorityRepository _priorityRepository;
        private readonly IRegionRepository _regionRepository;

        public UpdateDistributionInformationCommandHandler(
            IDistributionInformationRepository distributionInformationRepository,
            IPriorityRepository priorityRepository,
            IRegionRepository regionRepository)
        {
            _distributionInformationRepository = distributionInformationRepository;
            _priorityRepository = priorityRepository;
            _regionRepository = regionRepository;
        }
        public Task<Result<DistributionInformationDto>> Handle(UpdateDistributionInformationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
