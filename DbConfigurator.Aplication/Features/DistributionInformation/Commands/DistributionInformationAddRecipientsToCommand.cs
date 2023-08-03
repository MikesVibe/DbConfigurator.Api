using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Aplication.Features.DistributionInformation.Commands
{
    public class DistributionInformationAddRecipientsToCommand : IRequest
    {
        public int DisInfoId { get; }
        public IEnumerable<int> RecipientIds { get; }

        public DistributionInformationAddRecipientsToCommand(int disInfoId, IEnumerable<int> recipientIds)
        {
            DisInfoId = disInfoId;
            RecipientIds = recipientIds;
        }
    }
}
