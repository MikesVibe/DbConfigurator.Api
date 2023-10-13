using AutoMapper;
using DbConfigurator.Application.UnitTests.Common.Repositories;

namespace DbConfigurator.Application.UnitTests.Common.Fixtures
{
    internal class DistributionInformationHandlerFixtures
    {
        public DistributionInformationHandlerFixtures()
        {

        }

        public FakeRegionRepository RegionRepository { get; }
        public FakeDistributionInformationRepository DistributionInfromationRepository { get; }
        public Mapper Mapper { get; }
    }
}
