using DbConfigurator.API.DataAccess;
using DbConfigurator.API.DataAccess.Repository;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Domain.Model.Entities;
using DbConfigurator.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace DbConfigurator.Persistence.Repository
{
    public class RegionRepository : BaseRepository<Region>, IRegionRepository
    {
        public RegionRepository(DbConfiguratorApiDbContext dbContext) : base(dbContext)
        {
        }
        protected override IQueryable<Region> GetAllQueryable()
        {
            return _dbContext.Set<Region>()
                .Include(r => r.Area)
                .Include(r => r.BusinessUnit)
                .Include(r => r.Country)
                .AsQueryable();
        }
    }
}
