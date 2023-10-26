using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Create
{
    public class CreateDistributionInformationDto
    {
        public int RegionId { get; set; }
        public int PriorityId { get; set; }
        public ICollection<RecipientIdDto> RecipientsTo { get; set; } = new Collection<RecipientIdDto>();
        public ICollection<RecipientIdDto> RecipientsCc { get; set; } = new Collection<RecipientIdDto>();
    }
}
