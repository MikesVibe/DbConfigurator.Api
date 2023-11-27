using DbConfigurator.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.NotificationFeature
{
    public class DistributionListDto
    {
        public IEnumerable<RecipientDto> RecipientsTo {  get; set; } = Enumerable.Empty<RecipientDto>();
        public IEnumerable<RecipientDto> RecipientsCc {  get; set; } = Enumerable.Empty<RecipientDto>();
    }
}
