using DbConfigurator.Application.Contracts.Features.Create;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Application.Features.PriorityFeature.Commands.Create
{
    public class CreatePriorityDto : ICreateEntityDto
    {
        [Required]
        [MaxLength(6)]
        public string Name { get; set; } = string.Empty;
        [Required]
        public int Value { get; set; }
    }
}
