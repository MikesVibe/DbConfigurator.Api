using AutoMapper;
using DbConfigurator.Aplication.Features.DistributionInformation.Common.Dtos;
using DbConfigurator.Model.Entities.Core;

namespace DbConfigurator.Application.Profiles
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryDto>();
        }
    }
}
