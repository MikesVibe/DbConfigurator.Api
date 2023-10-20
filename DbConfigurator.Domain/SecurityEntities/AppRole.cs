using Microsoft.AspNetCore.Identity;

namespace DbConfigurator.Domain.SecurityEntities
{
    public class AppRole : IdentityRole<int>
    {
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}
