using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Model.Entities.Core;

namespace DbConfigurator.Application.Profiles
{
    public class AreaProfile : Profile
    {
        public AreaProfile()
        {
            CreateMap<Area, AreaDto>().ReverseMap();
        }
    }
}
