using DbConfigurator.API.DataAccess;
using DbConfigurator.API.DataAccess.Repository;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Model.Entities.Core;

namespace DbConfigurator.Persistence.Repository
{
    internal class PriorityRepository : BaseRepository<Priority>, IPriorityRepository
    {
        public PriorityRepository(DbConfiguratorApiDbContext dbContext) : base(dbContext)
        {
        }
    }
}
