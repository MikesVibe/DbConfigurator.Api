using DbConfigurator.Api.Models;
using DbConfigurator.Aplication.Contracts.Persistence;
using DbConfigurator.Model.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Aplication.UnitTests.Common
{
    internal class FakeDistributionInformationRepository : IDistributionInformationRepository
    {
        public Task AddAsync(DistributionInformation entity)
        {
            throw new NotImplementedException();
        }

        public Task AddRecipients(int disInfoId, IEnumerable<int> recipientIds)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(DistributionInformation value)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DistributionInformation>> GetAllAsync()
        {
            IEnumerable<DistributionInformation> list = new List<DistributionInformation>
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

            return list;
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
    }
}
