using AutoMapper;
using DbConfigurator.Aplication.Features.DistributionInformation.Common.Dtos;
using DbConfigurator.Model.Entities.Core;

namespace DbConfigurator.Api.Profiles
{
    public class RecipientProfile : Profile
    {
        public RecipientProfile()
        {
            CreateMap<Recipient, RecipientDto>();
        }
    }
}
