using Microsoft.AspNetCore.Identity;

namespace DbConfigurator.Domain.SecurityEntities
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}
