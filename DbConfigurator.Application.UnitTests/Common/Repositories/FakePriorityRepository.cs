using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Domain.Model.Entities;

namespace DbConfigurator.Application.UnitTests.Common.Repositories
{
    internal class FakePriorityRepository : IPriorityRepository
    {
        private bool _existsAsyncReturnValue;
        public FakePriorityRepository()
        {
            Initialize();
        }

        public IEnumerable<Priority> Priorities { get; set; } = Enumerable.Empty<Priority>();


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

        public async Task<IEnumerable<Priority>> GetAllAsync()
        {
            await Task.Delay(0);
            return Priorities;
        }

        public async Task<Priority?> GetByIdAsync(int id)
        {
            var list = await GetAllAsync();
            return list.FirstOrDefault(d => d.Id == id);
        }

        public Task<bool> UpdateAsync(Priority entity)
        {
            throw new NotImplementedException();
        }
        public void ExistsAsyncReturns(bool retrunValue)
        {
            _existsAsyncReturnValue = retrunValue;
        }

        private void Initialize()
        {
            Priorities = new List<Priority>()
            {
                new Priority()
                {
                    Id = 1,
                    Name = "P1"
                },
                new Priority()
                {
                    Id = 2,
                    Name = "P2"
                },
                new Priority()
                {
                    Id = 3,
                    Name = "P3"
                }
            };
        }
    }
}
