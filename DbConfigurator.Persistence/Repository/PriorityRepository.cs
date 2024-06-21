using DbConfigurator.API.DataAccess.Repository;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Domain.Model.Entities;
using DbConfigurator.Persistence.DatabaseContext;

namespace DbConfigurator.Persistence.Repository
{
    internal class PriorityRepository : BaseRepository<Priority>, IPriorityRepository
    {
        public PriorityRepository(DbConfiguratorApiDbContext dbContext) : base(dbContext)
        {
        }
    }
}
