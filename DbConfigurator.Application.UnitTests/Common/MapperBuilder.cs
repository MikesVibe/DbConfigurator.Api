using AutoMapper;
using DbConfigurator.Application.Profiles;

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
                    cfg.AddProfile<BusinessUnitProfile>();
                    cfg.AddProfile<CountryProfile>();
                });
        }
        public static Mapper Create(this MapperConfiguration cfg)
        {
            return new Mapper(cfg);
        }


    }
}
