using DbConfigurator.Application.Contracts.Features.Create;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Create
{
    public class CreateBusinessUnitDto : ICreateEntityDto
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; } = string.Empty;
    }
}
