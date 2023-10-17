using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Domain.Model.Entities;

namespace DbConfigurator.Application.Profiles
{
    public class RecipientProfile : Profile
    {
        public RecipientProfile()
        {
            CreateMap<Recipient, RecipientDto>().ReverseMap();
        }
    }
}
