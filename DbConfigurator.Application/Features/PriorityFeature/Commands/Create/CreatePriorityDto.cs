using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.PriorityFeature.Commands.Create
{
    public class CreatePriorityDto
    {
        [Required]
        [MaxLength(6)]
        public string Name { get; set; } = string.Empty;
    }
}
