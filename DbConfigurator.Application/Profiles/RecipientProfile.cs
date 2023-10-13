using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Model.Entities.Core;

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
