using DbConfigurator.Application.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Create
{
    public class CreateBusinessUnitDto : ICreateEntityDto
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; } = string.Empty;
    }
}
