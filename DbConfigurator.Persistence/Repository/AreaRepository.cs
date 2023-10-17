using DbConfigurator.API.DataAccess;
using DbConfigurator.API.DataAccess.Repository;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Persistence.Repository
{
    public class AreaRepository : BaseRepository<Area>, IAreaRepository
    {
        public AreaRepository(DbConfiguratorApiDbContext dbContext) : base(dbContext)
        {
        }
    }
}
