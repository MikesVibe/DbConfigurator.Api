using DbConfigurator.Domain.SecurityEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Contracts.Persistence
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
