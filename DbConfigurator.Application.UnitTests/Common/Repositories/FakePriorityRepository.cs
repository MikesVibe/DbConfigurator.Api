using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Model.Entities.Core;

namespace DbConfigurator.Application.UnitTests.Common.Repositories
{
    internal class FakePriorityRepository : IPriorityRepository
    {
        private bool _existsAsyncReturnValue;

        public Task<Priority> AddAsync(Priority entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Priority value)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            await Task.Delay(0);
            return _existsAsyncReturnValue;
        }

        public Task<IEnumerable<Priority>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Priority?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Priority entity)
        {
            throw new NotImplementedException();
        }
        public void ExistsAsyncReturns(bool retrunValue)
        {
            _existsAsyncReturnValue = retrunValue;
        }
    }
}
