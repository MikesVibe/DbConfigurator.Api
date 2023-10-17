using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;

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
