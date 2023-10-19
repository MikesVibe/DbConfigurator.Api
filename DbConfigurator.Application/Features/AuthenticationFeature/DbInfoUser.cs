using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.AuthenticationFeature
{
    public class DbInfoUser
    {
        public DbInfoUser(int userId, string userName, string firstName, string lastName)
        {
            UserId = userId;
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
        }

        public int UserId {  get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
