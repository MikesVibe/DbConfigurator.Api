using AutoMapper;
using DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformationList.Dtos;
using DbConfigurator.Model.Entities.Core;

namespace DbConfigurator.Api.Profiles
{
    public class RegionProfile : Profile
    {
        public RegionProfile()
        {
            CreateMap<Region, RegionDto>();
        }
    }
}
