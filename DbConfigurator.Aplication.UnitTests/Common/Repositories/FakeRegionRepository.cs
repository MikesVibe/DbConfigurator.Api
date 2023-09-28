using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Model.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.UnitTests.Common.Repositories
{
    public class FakeRegionRepository : IRegionRepository
    {
        public Task AddAsync(Region entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Region value)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Region>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Region?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Region entity)
        {
            throw new NotImplementedException();
        }
    }
}
