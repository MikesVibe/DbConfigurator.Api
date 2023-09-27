using DbConfigurator.Api.Models;
using DbConfigurator.Api.Services;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Model.Entities.Core
{
    public class Region : IEntity
    {
        [Required]
        public int Id { get; set; }
        public Area Area { get; set; } = new Area();
        public int AreaId { get; set; }
        public BuisnessUnit BuisnessUnit { get; set; } = new BuisnessUnit();
        public int BuisnessUnitId { get; set; }
        public Country Country { get; set; } = new Country();
        public int CountryId { get; set; }
        public ICollection<DistributionInformation> DistributionInformations { get; set; } = new Collection<DistributionInformation>();
    }
}
