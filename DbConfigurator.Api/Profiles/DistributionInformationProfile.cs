using AutoMapper;
using DbConfigurator.Api.Models;
using DbConfigurator.Model.DTOs.Core;

namespace DbConfigurator.Api.Profiles
{
    public class DistributionInformationProfile : Profile
    {
        public DistributionInformationProfile()
        {
            CreateMap<DistributionInformation, DistributionInformationDto>();
        }
    }
}
