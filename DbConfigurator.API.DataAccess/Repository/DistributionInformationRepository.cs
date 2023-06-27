using DbConfigurator.Api.Models;

namespace DbConfigurator.API.DataAccess.Repository
{
    public class DistributionInformationRepository : GenericRepository<DistributionInformation>
    {
        public DistributionInformationRepository(DbConfiguratorApiDbContext dbContext) : base(dbContext)
        {
        }


    }
}
