using DbConfigurator.Application.Contracts.Features.Update;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Update
{
    public class UpdateBusinessUnitDto : IUpdateEntityDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; } = string.Empty;
    }
}
