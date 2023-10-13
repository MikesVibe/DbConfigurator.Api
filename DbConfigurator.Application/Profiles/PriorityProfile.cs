using AutoMapper;
using DbConfigurator.Application.Features.DistributionInformation;
using DbConfigurator.Model.Entities.Core;

namespace DbConfigurator.Application.Profiles
{
    public class PriorityProfile : Profile
    {
        public PriorityProfile()
        {
            CreateMap<Priority, PriorityDto>().ReverseMap();
        }
    }
}
