using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;

namespace DbConfigurator.Application.Profiles
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryDto>().ReverseMap();
        }
    }
}
