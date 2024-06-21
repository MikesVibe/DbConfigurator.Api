using DbConfigurator.Application.Contracts.Features.Update;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Application.Features.PriorityFeature.Commands.Update
{
    public class UpdatePriorityDto : IUpdateEntityDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(6)]
        public string Name { get; set; } = string.Empty;
        [Required]
        public int Value { get; set; }
    }
}
