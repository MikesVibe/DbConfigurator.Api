using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;

namespace DbConfigurator.Application.Profiles
{
    public class PriorityProfile : Profile
    {
        public PriorityProfile()
        {
            CreateMap<Priority, PriorityDto>().ReverseMap();
        }
    }
}
