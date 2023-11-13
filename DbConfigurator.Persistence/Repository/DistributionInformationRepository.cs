using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Features.NotificationFeature;
using DbConfigurator.Domain.Model.Entities;
using DbConfigurator.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace DbConfigurator.API.DataAccess.Repository
{
    public class DistributionInformationRepository : BaseRepository<DistributionInformation>, IDistributionInformationRepository
    {
        public DistributionInformationRepository(DbConfiguratorApiDbContext dbContext) : base(dbContext)
        {
        }

        protected override IQueryable<DistributionInformation> GetAllQueryable()
        {
            return _dbContext.Set<DistributionInformation>()
                .Include(d => d.Region)
                    .ThenInclude(r => r.Area)
                .Include(d => d.Region)
                    .ThenInclude(r => r.BusinessUnit)
                .Include(d => d.Region)
                    .ThenInclude(r => r.Country)
                .Include(d => d.RecipientsCc)
                .Include(d => d.RecipientsTo)
                .Include(d => d.Priority)
                .AsQueryable();
        }

        public async Task<Tuple<IEnumerable<Recipient>, IEnumerable<Recipient>>>
            GetDistributionList(NotificationDataDto notificationData)
        {
            var matchingDisInfo = await GetAllQueryable().Where(d =>
            d.Priority.Value >= notificationData.PriorityValue && (
            d.Region.Country.CountryCode == notificationData.RegionName ||
            d.Region.Country.CountryName == notificationData.RegionName ||
            d.Region.BusinessUnit.Name == notificationData.RegionName ||
            d.Region.Area.Name == notificationData.RegionName
            )).ToListAsync();

            var allRecipientsTo = new List<Recipient>();
            var allRecipientsCc = new List<Recipient>();

            foreach(var disfInfo in  matchingDisInfo)
            {
                allRecipientsTo.AddRange(disfInfo.RecipientsTo);
                allRecipientsCc.AddRange(disfInfo.RecipientsCc);
            }

            return new Tuple<IEnumerable<Recipient>, IEnumerable<Recipient>>(allRecipientsTo, allRecipientsCc);
        }


    }
}
