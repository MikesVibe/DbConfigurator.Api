using DbConfigurator.Application.Contracts.Features.Create;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Application.Features.CountriesFeature.Commands.Create
{
    public class CreateCountryDto : ICreateEntityDto
    {
        [Required]
        [MaxLength(50)]
        public string CountryName { get; set; } = string.Empty;
        [Required]
        [MaxLength(3)]
        public string CountryCode { get; set; } = string.Empty;
    }
}
