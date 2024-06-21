using AutoMapper;
using DbConfigurator.Application.Features.AccountFeature;
using DbConfigurator.Domain.SecurityEntities;

namespace DbConfigurator.Application.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<AppUser, UserDto>();
            CreateMap<RegisterDto, AppUser>();
        }
    }
}
