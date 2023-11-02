using DbConfigurator.Application.Contracts.Features.Update;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.AreaFeature.Commands.Update
{
    public class UpdateAreaDto : IUpdateEntityDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
    }
}
