using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.UnitTests.Common.Repositories
{
    public class FakeAreaRepository : FakeBaseRepository<Area>, IAreaRepository
    {
        protected override IEnumerable<Area> InitializeEntities()
        {
            return new List<Area>();
        }
    }
}
