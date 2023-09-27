using DbConfigurator.Api.Models;
using DbConfigurator.Api.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Model.Entities.Core
{
    public class Recipient : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        public ICollection<DistributionInformation> RecipientGroupTo { get; set; } = new Collection<DistributionInformation>();
        public ICollection<DistributionInformation> RecipientGroupCc { get; set; } = new Collection<DistributionInformation>();
    }
}
