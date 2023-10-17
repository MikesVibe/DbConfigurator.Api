using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.Area;
using DbConfigurator.Domain.Model.Entities;

namespace DbConfigurator.Application.Profiles
{
    public class AreaProfile : Profile
    {
        public AreaProfile()
        {
            CreateMap<Area, AreaDto>().ReverseMap();
            CreateMap<AreaCreateDto, Area>();
        }
    }
}
