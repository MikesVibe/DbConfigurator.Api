using DbConfigurator.Application.Contracts.Features.Create;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Application.Features.AreaFeature.Commands.Create
{
    public class CreateAreaDto : ICreateEntityDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
    }
}
