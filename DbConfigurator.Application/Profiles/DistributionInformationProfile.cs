﻿using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Create;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Update;
using DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationDetails;
using DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationList;
using DbConfigurator.Domain.Model.Entities;

namespace DbConfigurator.Application.Profiles
{
    public class DistributionInformationProfile : Profile
    {
        public DistributionInformationProfile()
        {
            CreateMap<DistributionInformation, DistributionInformationItem>();
            CreateMap<DistributionInformation, DistributionInformationDetails>();
            CreateMap<DistributionInformationDto, DistributionInformation>().ReverseMap();
            CreateMap<UpdateDistributionInformationDto, DistributionInformation>();
            CreateMap<CreateDistributionInformationDto, DistributionInformation>().ReverseMap();
        }
    }
}
