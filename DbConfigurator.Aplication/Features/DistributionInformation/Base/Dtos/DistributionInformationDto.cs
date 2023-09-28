using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.DistributionInformation.Base.Dtos
{
    public class DistributionInformationDto
    {
        public int Id { get; init; }
        public RegionDto Region { get; set; } = default!;
        public PriorityDto Priority { get; set; } = default!;
        public List<RecipientDto> RecipientsTo { get; set; } = new();
        public List<RecipientDto> RecipientsCc { get; set; } = new();
    }
}
