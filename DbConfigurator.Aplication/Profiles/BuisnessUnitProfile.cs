using AutoMapper;
using DbConfigurator.Api.Models;
using DbConfigurator.Application.Features.DistributionInformation;
using DbConfigurator.Model.Entities.Core;

namespace DbConfigurator.Application.Profiles
{
    public class BuisnessUnitProfile : Profile 
    {
        public BuisnessUnitProfile()
        {
            CreateMap<BuisnessUnit, BuisnessUnitDto>().ReverseMap();
        }
    }
}
