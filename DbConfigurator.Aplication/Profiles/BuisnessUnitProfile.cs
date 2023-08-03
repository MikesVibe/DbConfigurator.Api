using AutoMapper;
using DbConfigurator.Api.Models;
using DbConfigurator.Aplication.Features.DistributionInformation.Common.Dtos;
using DbConfigurator.Model.Entities.Core;

namespace DbConfigurator.Api.Profiles
{
    public class BuisnessUnitProfile : Profile 
    {
        public BuisnessUnitProfile()
        {
            CreateMap<BuisnessUnit, BuisnessUnitDto>();
        }
    }
}
