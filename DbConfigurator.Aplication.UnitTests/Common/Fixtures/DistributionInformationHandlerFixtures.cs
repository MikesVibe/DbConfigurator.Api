using AutoMapper;
using DbConfigurator.Application.UnitTests.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.UnitTests.Common.Fixtures
{
    internal class DistributionInformationHandlerFixtures
    {
        public DistributionInformationHandlerFixtures()
        {
        
        }

        public FakeRegionRepository RegionRepository{ get; }
        public FakeDistributionInformationRepository DistributionInfromationRepository { get; }
        public Mapper Mapper { get; }
    }
}
