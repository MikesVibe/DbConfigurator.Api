using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Application.Dtos
{
    public class PriorityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [Required]
        public int Value { get; set; }
    }
}
