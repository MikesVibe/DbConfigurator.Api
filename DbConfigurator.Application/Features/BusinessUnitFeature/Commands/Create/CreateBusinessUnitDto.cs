using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Create
{
    public class CreateBusinessUnitDto
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; } = string.Empty;
    }
}
