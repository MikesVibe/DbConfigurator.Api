using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.NotificationFeature
{
    public class DistributionList
    {
        public IEnumerable<Recipient> RecipientsTo { get; set; } = Enumerable.Empty<Recipient>();
        public IEnumerable<Recipient> RecipientsCc { get; set; } = Enumerable.Empty<Recipient>();
    }
}
