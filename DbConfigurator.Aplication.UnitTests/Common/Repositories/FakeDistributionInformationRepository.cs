using DbConfigurator.Api.Models;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Features.DistributionInformation;
using DbConfigurator.Model.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.UnitTests.Common.Repositories
{
    internal class FakeDistributionInformationRepository : IDistributionInformationRepository
    {
        public FakeDistributionInformationRepository()
        {
            InitializeDistributionInformation();
        }


        public IEnumerable<Api.Models.DistributionInformation> DistributionInformation { get; set; } = Enumerable.Empty<Api.Models.DistributionInformation>();
        public Task AddAsync(Api.Models.DistributionInformation entity)
        {
            throw new NotImplementedException();
        }

        public Task AddRecipients(int disInfoId, IEnumerable<int> recipientIds)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Api.Models.DistributionInformation value)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Api.Models.DistributionInformation>> GetAllAsync()
        {
            await Task.Delay(0);
            return DistributionInformation;
        }

        public async Task<Api.Models.DistributionInformation?> GetByIdAsync(int id)
        {
            var list = await GetAllAsync();
            return list.FirstOrDefault(d => d.Id == id);
        }

        public Task<bool> UpdateAsync(Api.Models.DistributionInformation entity)
        {
            throw new NotImplementedException();
        }

        public DistributionInformationDto GetNotExistingDistributionInformationDto()
        {
            throw new NotImplementedException();
        }

        private void InitializeDistributionInformation()
        {
            DistributionInformation = new List<Api.Models.DistributionInformation>
            {
                new Api.Models.DistributionInformation()
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
                        BuisnessUnit=new BuisnessUnit()
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
                new Api.Models.DistributionInformation()
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
                        BuisnessUnit=new BuisnessUnit()
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
                new Api.Models.DistributionInformation()
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
                        BuisnessUnit=new BuisnessUnit()
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

    }
}
