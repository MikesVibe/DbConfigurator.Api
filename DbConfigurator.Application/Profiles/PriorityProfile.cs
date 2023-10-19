using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.PriorityFeature.Commands.Create;
using DbConfigurator.Application.Features.PriorityFeature.Commands.Update;
using DbConfigurator.Domain.Model.Entities;

namespace DbConfigurator.Application.Profiles
{
    public class PriorityProfile : Profile
    {
        public PriorityProfile()
        {
            CreateMap<Priority, PriorityDto>().ReverseMap();
            CreateMap<CreatePriorityDto, Priority>();
            CreateMap<UpdatePriorityDto, Priority>();
        }
    }
}
