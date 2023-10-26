using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.CountriesFeature.Commands.Create
{
    public class CreateCountryDto
    {
        [Required]
        [MaxLength(50)]
            public string CountryName { get; set; } = string.Empty;
            [Required]
            [MaxLength(3)]
            public string CountryCode { get; set; } = string.Empty;
    }
}
