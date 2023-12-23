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

        public Task<Tuple<IEnumerable<Recipient>, IEnumerable<Recipient>>> GetDistributionListBySingleName(NotificationDataDto notificationData)
        {
            throw new NotImplementedException();
        }

       
    }
}
