using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Model.Entities.Core
{
    public class Country
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string CountryName { get; set; } = string.Empty;
        [Required]
        [MaxLength(3)]
        public string CountryCode { get; set; } = string.Empty;
        public ICollection<Region> Regions { get; set; } = new Collection<Region>();
    }
}
