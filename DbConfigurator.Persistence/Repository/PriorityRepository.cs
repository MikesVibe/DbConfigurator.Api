using DbConfigurator.API.DataAccess;
using DbConfigurator.API.DataAccess.Repository;
using DbConfigurator.Aplication.Contracts.Persistence;
using DbConfigurator.Model.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Persistence.Repository
{
    internal class PriorityRepository : BaseRepository<Priority>, IPriorityRepository
    {
        public PriorityRepository(DbConfiguratorApiDbContext dbContext) : base(dbContext)
        {
        }
    }
}
