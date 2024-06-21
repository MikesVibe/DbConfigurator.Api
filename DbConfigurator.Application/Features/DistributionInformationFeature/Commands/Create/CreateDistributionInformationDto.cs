using DbConfigurator.Application.Contracts.Features.Create;
using System.Collections.ObjectModel;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Create
{
    public class CreateDistributionInformationDto : ICreateEntityDto
    {
        public int RegionId { get; set; }
        public int PriorityId { get; set; }
        public ICollection<RecipientIdDto> RecipientsTo { get; set; } = new Collection<RecipientIdDto>();
        public ICollection<RecipientIdDto> RecipientsCc { get; set; } = new Collection<RecipientIdDto>();
    }
}
