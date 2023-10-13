using DbConfigurator.API.DataAccess;
using DbConfigurator.API.DataAccess.Repository;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Model.Entities.Core;

namespace DbConfigurator.Persistence.Repository
{
    public class RegionRepository : BaseRepository<Region>, IRegionRepository
    {
        public RegionRepository(DbConfiguratorApiDbContext dbContext) : base(dbContext)
        {
        }
    }
}
