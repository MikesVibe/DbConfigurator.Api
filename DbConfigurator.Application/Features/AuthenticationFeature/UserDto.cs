using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.AuthenticationFeature
{
    public class UserDto
    {
        public string Email { get; set; }
        public string Token { get; set; }
        public string DisplayName { get; set; }
    }
}
