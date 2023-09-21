using AutoMapper;
using DbConfigurator.Api.Models;
using DbConfigurator.Aplication.Features.DistributionInformation.Common.Dtos;
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
