using DbConfigurator.Api.Services;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Domain.Model.Entities
{
    public class BusinessUnit : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; } = string.Empty;
        public ICollection<Region> Regions { get; set; } = new Collection<Region>();
    }
}