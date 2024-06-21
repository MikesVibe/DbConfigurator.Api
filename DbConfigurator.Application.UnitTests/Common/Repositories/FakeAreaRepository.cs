using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Domain.Model.Entities;

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
