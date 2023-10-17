using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;   

namespace DbConfigurator.Application.Profiles
{
    public class BusinessUnitProfile : Profile
    {
        public BusinessUnitProfile()
        {
            CreateMap<BusinessUnit, BusinessUnitDto>().ReverseMap();
        }
    }
}
