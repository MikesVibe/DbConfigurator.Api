using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;

namespace DbConfigurator.Application.UnitTests.Common.Repositories
{
    public class FakeRegionRepository : IRegionRepository
    {
        private bool _existsAsyncReturnValue;

        public FakeRegionRepository()
        {
            Initialize();
        }

        public IEnumerable<Region> Regions { get; set; } = Enumerable.Empty<Region>();


        public Task<Result<Region>> AddAsync(Region entity)
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

        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            await Task.Delay(0);
            return Regions;
        }

        public async Task<Region?> GetByIdAsync(int id)
        {
            var list = await GetAllAsync();
            return list.FirstOrDefault(d => d.Id == id);
        }

        public Task<bool> UpdateAsync(Region entity)
        {
            throw new NotImplementedException();
        }
        public void ExistsAsyncReturns(bool retrunValue)
        {
            _existsAsyncReturnValue = retrunValue;
        }

        private void Initialize()
        {
            Regions = new List<Region>()
            {
                new Region()
                {
                    Id = 1,
                    Area = new Area()
                    {
                        Id = 1,
                        Name = "America"
                    },
                    BusinessUnit = new BusinessUnit()
                    {
                        Id = 1,
                        Name = "NAO"
                    },
                    Country = new Country()
                    {
                        Id = 1,
                        CountryName = "Canada",
                        CountryCode = "CA"
                    }
                },
                new Region()
                {
                    Id = 2,
                    Area = new Area()
                    {
                        Id = 82,
                        Name = "Central Europe"
                    },
                    BusinessUnit = new BusinessUnit()
                    {
                        Id = 2,
                        Name = "GER"
                    },
                    Country = new Country()
                    {
                        Id = 2,
                        CountryName = "Germany",
                        CountryCode = "DE"
                    }
                },
                new Region()
                {
                    Id = 3,
                    Area = new Area()
                    {
                        Id = 3,
                        Name = "Southern Europe"
                    },
                    BusinessUnit = new BusinessUnit()
                    {
                        Id = 3,
                        Name = "FRA"
                    },
                    Country = new Country()
                    {
                        Id = 3,
                        CountryName = "New Caledonia",
                        CountryCode = "NC"
                    }
                }
            };

        }
    }
}
