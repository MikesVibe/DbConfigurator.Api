using DbConfigurator.Api.Services;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Aplication.Features.DistributionInformation.Base.Dtos
{
    public class AreaDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
    }
}
