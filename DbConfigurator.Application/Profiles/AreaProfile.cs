using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.AreaFeature;
using DbConfigurator.Domain.Model.Entities;

namespace DbConfigurator.Application.Profiles
{
    public class AreaProfile : Profile
    {
        public AreaProfile()
        {
            CreateMap<Area, AreaDto>().ReverseMap();
            CreateMap<CreateAreaDto, Area>();
            CreateMap<UpdateAreaDto, Area>();
        }
    }
}
