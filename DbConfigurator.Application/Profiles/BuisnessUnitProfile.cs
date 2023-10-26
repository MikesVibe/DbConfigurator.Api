using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Create;
using DbConfigurator.Application.Features.BusinessUnitFeature.Commands.Update;
using DbConfigurator.Domain.Model.Entities;

namespace DbConfigurator.Application.Profiles
{
    public class BusinessUnitProfile : Profile
    {
        public BusinessUnitProfile()
        {
            CreateMap<BusinessUnit, BusinessUnitDto>().ReverseMap();
            CreateMap<CreateBusinessUnitDto, BusinessUnit>();
            CreateMap<UpdateBusinessUnitDto, BusinessUnit>();
        }
    }
}
