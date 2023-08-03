using AutoMapper;
using DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformationList.Dtos;
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
