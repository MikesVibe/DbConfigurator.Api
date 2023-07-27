using AutoMapper;
using DbConfigurator.Api.Models;
using DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformation;
using DbConfigurator.Model.DTOs.Core;

namespace DbConfigurator.Api.Profiles
{
    public class DistributionInformationProfile : Profile
    {
        public DistributionInformationProfile()
        {
            CreateMap<DistributionInformation, DistributionInformationListItem>();
        }
    }
}
