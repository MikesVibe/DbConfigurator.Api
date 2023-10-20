using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Domain.SecurityEntities
{
    public class AppUser : IdentityUser<int>
    {
        [Required]
        public string DisplayName { get; set; }

        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}
