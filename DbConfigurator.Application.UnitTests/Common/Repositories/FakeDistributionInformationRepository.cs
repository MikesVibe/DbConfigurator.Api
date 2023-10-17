using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Domain.Model.Entities;

namespace DbConfigurator.Application.UnitTests.Common.Repositories
{
    internal class FakeDistributionInformationRepository : IDistributionInformationRepository
    {
        public FakeDistributionInformationRepository()
        {
            InitializeDistributionInformation();
        }


        public IEnumerable<DistributionInformation> DistributionInformation { get; set; } = new List<DistributionInformation>();

        public bool ExistsAsyncReturnValue { get; private set; }

        public async Task<DistributionInformation> AddAsync(DistributionInformation entity)
        {
            await Task.Delay(0);
            return entity;
        }

        public Task AddRecipients(int disInfoId, IEnumerable<int> recipientIds)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(DistributionInformation value)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            await Task.Delay(0);
            return ExistsAsyncReturnValue;
        }

        public async Task<IEnumerable<DistributionInformation>> GetAllAsync()
        {
            await Task.Delay(0);
            return DistributionInformation;
        }

        public async Task<DistributionInformation?> GetByIdAsync(int id)
        {
            var list = await GetAllAsync();
            return list.FirstOrDefault(d => d.Id == id);
        }

        public Task<bool> UpdateAsync(DistributionInformation entity)
        {
            throw new NotImplementedException();
        }


        private void InitializeDistributionInformation()
        {
            DistributionInformation = new List<DistributionInformation>
            {
                new DistributionInformation()
                {
                    Id=1,
                    Region = new Region()
                    {
                        Id=1,
                        Area= new Area()
                        {
                            Id=1,
                            Name="America"
                        },
                        BusinessUnit=new BusinessUnit()
                        {
                            Id=1,
                            Name="NAO"
                        },
                        Country=new Country()
                        {
                            Id=1,
                            CountryName="Canada",
                            CountryCode="CA"
                        }
                    },
                    Priority=new Priority()
                    {
                        Id=1,
                        Name="P1"
                    }
                },
                new DistributionInformation()
                {
                    Id=2,
                    Region = new Region()
                    {
                        Id=2,
                        Area= new Area()
                        {
                            Id=82,
                            Name="Central Europe"
                        },
                        BusinessUnit=new BusinessUnit()
                        {
                            Id=2,
                            Name="GER"
                        },
                        Country=new Country()
                        {
                            Id=2,
                            CountryName="Germany",
                            CountryCode="DE"
                        }
                    },
                    Priority=new Priority()
                    {
                        Id=2,
                        Name="P2"
                    }
                },
                new DistributionInformation()
  {
                    Id=3,
                    Region = new Region()
                    {
                        Id=3,
                        Area= new Area()
                        {
                            Id=3,
                            Name="Southern Europe"
                        },
                        BusinessUnit=new BusinessUnit()
                        {
                            Id=3,
                            Name="FRA"
                        },
                        Country=new Country()
                        {
                            Id=3,
                            CountryName="New Caledonia",
                            CountryCode="NC"
                        }
                    },
                    Priority=new Priority()
                    {
                        Id=3,
                        Name="P3"
                    }
                }
            };
        }


        public void ExistsAsyncReturns(bool retrunValue)
        {
            ExistsAsyncReturnValue = retrunValue;
        }
    }
}
