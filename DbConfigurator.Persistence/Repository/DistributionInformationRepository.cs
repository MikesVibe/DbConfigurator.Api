using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.NotificationFeature;
using DbConfigurator.Domain.Model.Entities;
using DbConfigurator.Persistence.DatabaseContext;
using FluentResults;
using Microsoft.EntityFrameworkCore;

namespace DbConfigurator.API.DataAccess.Repository
{
    public class DistributionInformationRepository : BaseRepository<DistributionInformation>, IDistributionInformationRepository
    {
        public enum RegionField
        {
            Area = 0,
            BusinessUnit = 1,
            CountryName = 2,
            CountryCode = 3
        }
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

        public async Task<Result<DistributionList>> GetDistributionListBySingleName(NotificationDataDto notificationData)
        {
            var matchinRegionField = DetermineMatchingRegionField(notificationData.GBU);

            var matchingDisInfo = GetDisInfoWithMatchingRegionField(matchinRegionField);

            var matchingDisInfoByPriority = matchingDisInfo.Where(d =>
            d.Priority.Value >= notificationData.PriorityValue);

            var allRecipientsTo = new List<Recipient>();
            var allRecipientsCc = new List<Recipient>();

            foreach (var disfInfo in matchingDisInfoByPriority)
            {
                allRecipientsTo.AddRange(disfInfo.RecipientsTo);
                allRecipientsCc.AddRange(disfInfo.RecipientsCc);
            }

            return new DistributionList { RecipientsTo = allRecipientsTo, RecipientsCc = allRecipientsCc };
        }

        private Result<IQueryable<DistributionInformation>> GetDisInfoWithMatchingRegionField(RegionField matchinRegionField)
        {
            switch (matchinRegionField)
            {
                case RegionField.Area:
                    {

                        break;
                    }
                case RegionField.BusinessUnit:
                    {

                        break;
                    }
                case RegionField.CountryName:
                    {

                        break;
                    }
                case RegionField.CountryCode:
                    {

                        break;
                    }
                default:
                    {
                        return Result.Fail("Fail");
                    }
            }
        }

        private RegionField DetermineMatchingRegionField(string gbu)
        {
            var matchingByArea = GetAllQueryable().Where(d =>
            d.Region.Area.Name == gbu);

            if (matchingByArea.Count() > 0)
                return RegionField.Area;

            var matchingByBusinessUnit = GetAllQueryable().Where(d =>
            d.Region.BusinessUnit.Name == gbu);

            if (matchingByBusinessUnit.Count() > 0)
                return RegionField.BusinessUnit;

            var matchingByCountryName = GetAllQueryable().Where(d =>
            d.Region.Country.CountryName == gbu);

            if (matchingByCountryName.Count() > 0)
                return RegionField.CountryName;


            var matchingByCountryCode = GetAllQueryable().Where(d =>
            d.Region.Country.CountryCode == gbu);

            if (matchingByCountryCode.Count() > 0)
                return RegionField.CountryCode;

            return RegionField.Default;
        }
    }
}
