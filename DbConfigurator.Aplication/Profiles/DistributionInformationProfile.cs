using AutoMapper;
using DbConfigurator.Api.Models;
using DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformationDetails;
using DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformationList;
using DbConfigurator.Model.DTOs.Core;

namespace DbConfigurator.Application.Profiles
{
    public class DistributionInformationProfile : Profile
    {
        public DistributionInformationProfile()
        {
            CreateMap<DistributionInformation, DistributionInformationItem>();
            CreateMap<DistributionInformation, DistributionInformationDetails>();
        }
    }
}
