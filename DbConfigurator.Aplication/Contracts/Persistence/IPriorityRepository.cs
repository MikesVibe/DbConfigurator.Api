using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Model.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Aplication.Contracts.Persistence
{
    public interface IPriorityRepository : IRepository<Priority>
    {
    }
}
