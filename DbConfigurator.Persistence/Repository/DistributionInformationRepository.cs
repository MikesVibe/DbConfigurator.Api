using DbConfigurator.Api.Models;
using DbConfigurator.Aplication.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DbConfigurator.API.DataAccess.Repository
{
    public class DistributionInformationRepository : BaseRepository<DistributionInformation>, IDistributionInformationRepository
    {
        public DistributionInformationRepository(DbConfiguratorApiDbContext dbContext) : base(dbContext)
        {
        }
        public override async Task<IEnumerable<DistributionInformation>> GetAllAsync()
        {
            return await QueryableDistributionInformation()
                .AsNoTracking().ToListAsync();
        }
        public override async Task<DistributionInformation?> GetByIdAsync(int id)
        {
            return await QueryableDistributionInformation()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        private IQueryable<DistributionInformation> QueryableDistributionInformation()
        {
            return _dbContext.Set<DistributionInformation>()
                .Include(d => d.Region)
                    .ThenInclude(r => r.Area)
                .Include(d => d.Region)
                    .ThenInclude(r => r.BuisnessUnit)
                .Include(d => d.Region)
                    .ThenInclude(r => r.Country)
                .Include(d => d.RecipientsCc)
                .Include(d => d.RecipientsTo)
                .Include(d => d.Priority)
                .AsQueryable();
        }
    }
}
