using DbConfigurator.Api.Services;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Domain.Model.Entities
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
