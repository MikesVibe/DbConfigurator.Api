using DbConfigurator.Domain.Model.Entities;

namespace DbConfigurator.Application.Features.NotificationFeature
{
    public class DistributionList
    {
        public IEnumerable<Recipient> RecipientsTo { get; set; } = Enumerable.Empty<Recipient>();
        public IEnumerable<Recipient> RecipientsCc { get; set; } = Enumerable.Empty<Recipient>();
    }
}
