using AutoMapper;
using DbConfigurator.Aplication.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Aplication.Features.DistributionInformation.Commands
{
    public class DistributionInformationAddRecipientsToCommandHandler : IRequestHandler<DistributionInformationAddRecipientsToCommand>
    {
        private readonly IDistributionInformationRepository _repository;
        private readonly IMapper _mapper;

        public DistributionInformationAddRecipientsToCommandHandler(IDistributionInformationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DistributionInformationAddRecipientsToCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddRecipients(request.DisInfoId, request.RecipientIds);
            return Unit.Value;
        }
    }
}
