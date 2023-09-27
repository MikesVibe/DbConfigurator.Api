using AutoMapper;
using DbConfigurator.Aplication.Features.DistributionInformation.Base.Dtos;
using DbConfigurator.Model.Entities.Core;

namespace DbConfigurator.Application.Profiles
{
    public class RegionProfile : Profile
    {
        public RegionProfile()
        {
            CreateMap<Region, RegionDto>();
        }
    }
}
