using DbConfigurator.API.DataAccess;
using DbConfigurator.API.DataAccess.Repository;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Persistence.Repository
{
    public class RecipientRepository : BaseRepository<Recipient>, IRecipientRepository
    {
        public RecipientRepository(DbConfiguratorApiDbContext dbContext) : base(dbContext)
        {
        }
    }
}
