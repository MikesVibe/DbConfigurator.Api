using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Application.Features.AccountFeature
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
