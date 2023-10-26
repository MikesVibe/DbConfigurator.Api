using AutoMapper;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.DistributionInformationFeature;
using DbConfigurator.Application.Features.RecipientFeature.Commands.Create;
using DbConfigurator.Application.Features.RecipientFeature.Commands.Update;
using DbConfigurator.Domain.Model.Entities;

namespace DbConfigurator.Application.Profiles
{
    public class RecipientProfile : Profile
    {
        public RecipientProfile()
        {
            CreateMap<Recipient, RecipientDto>().ReverseMap();
            CreateMap<RecipientIdDto, Recipient>();
            CreateMap<CreateRecipientDto, Recipient>();
            CreateMap<UpdateRecipientDto, Recipient>();
        }
    }
}
