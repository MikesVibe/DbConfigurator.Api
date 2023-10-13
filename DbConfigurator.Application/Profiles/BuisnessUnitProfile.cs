﻿using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Model.Entities.Core;

namespace DbConfigurator.Application.Profiles
{
    public class BuisnessUnitProfile : Profile
    {
        public BuisnessUnitProfile()
        {
            CreateMap<BuisnessUnit, BuisnessUnitDto>().ReverseMap();
        }
    }
}
