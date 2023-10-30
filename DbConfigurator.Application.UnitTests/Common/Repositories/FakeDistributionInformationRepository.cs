using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Domain.Model.Entities;

namespace DbConfigurator.Application.UnitTests.Common.Repositories
{
    internal class FakeDistributionInformationRepository : FakeBaseRepository<DistributionInformation>, IDistributionInformationRepository
    {
        public FakeDistributionInformationRepository()
        {
            InitializeEntities();
        }

        public Task AddRecipients(int disInfoId, IEnumerable<int> recipientIds)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<DistributionInformation> InitializeEntities()
        {
            return new List<DistributionInformation>
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
    }
}
