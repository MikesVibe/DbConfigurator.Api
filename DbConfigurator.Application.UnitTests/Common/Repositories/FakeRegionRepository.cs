using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Model.Entities.Core;

namespace DbConfigurator.Application.UnitTests.Common.Repositories
{
    public class FakeRegionRepository : IRegionRepository
    {
        private bool _existsAsyncReturnValue;

        public Task<Region> AddAsync(Region entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Region value)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            await Task.Delay(0);
            return _existsAsyncReturnValue;
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
        public void ExistsAsyncReturns(bool retrunValue)
        {
            _existsAsyncReturnValue = retrunValue;
        }
    }
}
