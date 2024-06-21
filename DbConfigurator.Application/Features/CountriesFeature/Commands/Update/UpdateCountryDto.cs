using DbConfigurator.Application.Contracts.Features.Update;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Application.Features.CountriesFeature.Commands.Update
{
    public class UpdateCountryDto : IUpdateEntityDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string CountryName { get; set; } = string.Empty;
        [Required]
        [MaxLength(3)]
        public string CountryCode { get; set; } = string.Empty;
    }
}
