using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.RegionFeature.Commands.Create;
using DbConfigurator.Application.Features.RegionFeature.Commands.Update;
using DbConfigurator.Domain.Model.Entities;

namespace DbConfigurator.Application.Profiles
{
    public class RegionProfile : Profile
    {
        public RegionProfile()
        {
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<CreateRegionDto, Region>();
            CreateMap<UpdateRegionDto, Region>();
        }
    }
}
