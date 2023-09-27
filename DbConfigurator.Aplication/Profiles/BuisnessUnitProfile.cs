using AutoMapper;
using DbConfigurator.Api.Models;
using DbConfigurator.Aplication.Features.DistributionInformation.Base.Dtos;
using DbConfigurator.Model.Entities.Core;

namespace DbConfigurator.Application.Profiles
{
    public class BuisnessUnitProfile : Profile 
    {
        public BuisnessUnitProfile()
        {
            CreateMap<BuisnessUnit, BuisnessUnitDto>();
        }
    }
}
