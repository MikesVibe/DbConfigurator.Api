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
        public Area Area { get; set; }
        public int AreaId { get; set; }
        public BusinessUnit BusinessUnit { get; set; }
        public int BusinessUnitId { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public ICollection<DistributionInformation> DistributionInformations { get; set; } = new Collection<DistributionInformation>();
    }
}
