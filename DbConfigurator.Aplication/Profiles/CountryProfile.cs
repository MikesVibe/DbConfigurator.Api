using AutoMapper;
using DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformationList.Dtos;
using DbConfigurator.Model.Entities.Core;

namespace DbConfigurator.Api.Profiles
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryDto>();
        }
    }
}
