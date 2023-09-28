using AutoMapper;
using DbConfigurator.Api.Models;
using DbConfigurator.Application.Features.DistributionInformation.Base.Dtos;
using DbConfigurator.Model.Entities.Core;

namespace DbConfigurator.Application.Profiles
{
    public class AreaProfile : Profile
    {
        public AreaProfile()
        {
            CreateMap<Area, AreaDto>();
        }
    }
}
