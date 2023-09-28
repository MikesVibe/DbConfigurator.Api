using AutoMapper;
using DbConfigurator.Application.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.UnitTests.Common
{
    public static class MapperBuilder
    {
        public static MapperConfiguration AddDistributionInformationProfiles()
        {
            return new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile<DistributionInformationProfile>();
                    cfg.AddProfile<RegionProfile>();
                    cfg.AddProfile<PriorityProfile>();
                    cfg.AddProfile<AreaProfile>();
                    cfg.AddProfile<BuisnessUnitProfile>();
                    cfg.AddProfile<CountryProfile>();
                });
        }
        public static Mapper Create(this MapperConfiguration cfg)
        {
            return new Mapper(cfg);
        }


    }
}
