using DbConfigurator.Aplication.Features.DistributionInformation.Base.Dtos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformationList
{
    public class DistributionInformationItem
    {
        public int Id { get; init; }
        public RegionDto Region { get; set; } = default!;
        public PriorityDto Priority { get; set; } = default!;
        public List<RecipientDto> RecipientsTo { get; set; } = new();
        public List<RecipientDto> RecipientsCc { get; set; } = new();
    }
}
