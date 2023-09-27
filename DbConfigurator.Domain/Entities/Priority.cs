using DbConfigurator.Api.Models;
using DbConfigurator.Api.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Model.Entities.Core
{
    public class Priority : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(6)]
        public string Name { get; set; } = string.Empty;
        public ICollection<DistributionInformation> DistributionInformations { get; set; } = new Collection<DistributionInformation>();
    }
}
