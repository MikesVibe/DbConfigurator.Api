using DbConfigurator.Api.Services;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Domain.Model.Entities
{
    public class DistributionInformation : IEntity
    {
        [Required]
        public int Id { get; set; }
        public Region Region { get; set; }
        public int RegionId { get; set; }
        [Required]
        public int PriorityId { get; set; }
        public Priority Priority { get; set; }
        public ICollection<Recipient> RecipientsTo { get; set; } = new Collection<Recipient>();
        public ICollection<Recipient> RecipientsCc { get; set; } = new Collection<Recipient>();
    }
}
