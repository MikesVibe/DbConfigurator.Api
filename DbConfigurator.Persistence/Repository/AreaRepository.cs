using DbConfigurator.API.DataAccess.Repository;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Domain.Model.Entities;
using DbConfigurator.Persistence.DatabaseContext;

namespace DbConfigurator.Persistence.Repository
{
    public class AreaRepository : BaseRepository<Area>, IAreaRepository
    {
        public AreaRepository(DbConfiguratorApiDbContext dbContext) : base(dbContext)
        {
        }
    }
}
