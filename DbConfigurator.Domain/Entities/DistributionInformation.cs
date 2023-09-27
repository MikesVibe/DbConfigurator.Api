﻿using DbConfigurator.Api.Services;
using DbConfigurator.Model.Entities.Core;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Api.Models
{
    public class DistributionInformation : IEntity
    {
        [Required]
        public int Id { get; set; }
        public Region Region { get; set; } = new Region();
        public int RegionId { get; set; }
        [Required]
        public int PriorityId { get; set; }
        public Priority Priority { get; set; } = new Priority();
        public ICollection<Recipient> RecipientsTo { get; set; } = new Collection<Recipient>();
        public ICollection<Recipient> RecipientsCc { get; set; } = new Collection<Recipient>();
    }
}
