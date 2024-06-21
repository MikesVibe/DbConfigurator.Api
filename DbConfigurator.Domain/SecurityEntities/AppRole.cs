using Microsoft.AspNetCore.Identity;

namespace DbConfigurator.Domain.SecurityEntities
{
    public class AppRole : IdentityRole<int>
    {
        public AppRole(string name) : base(name)
        {
        }

        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}
