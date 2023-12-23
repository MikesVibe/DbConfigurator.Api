using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.AccountFeature;
using DbConfigurator.Domain.Model.Entities;
using DbConfigurator.Domain.SecurityEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
