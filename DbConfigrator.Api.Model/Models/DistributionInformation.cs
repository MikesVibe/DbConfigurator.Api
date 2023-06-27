using DbConfigurator.Api.Services;
using DbConfigurator.Model.Entities.Core;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Api.Models
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


        public ICollection<Recipient> RecipientsTo { get; set; }
        public ICollection<Recipient> RecipientsCc { get; set; }
    }
}
