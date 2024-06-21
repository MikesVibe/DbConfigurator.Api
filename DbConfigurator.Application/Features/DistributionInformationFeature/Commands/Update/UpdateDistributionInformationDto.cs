using DbConfigurator.Application.Contracts.Features.Update;
using System.Collections.ObjectModel;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Update
{
    public class UpdateDistributionInformationDto : IUpdateEntityDto
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public int PriorityId { get; set; }
        public ICollection<RecipientIdDto> RecipientsTo { get; set; } = new Collection<RecipientIdDto>();
        public ICollection<RecipientIdDto> RecipientsCc { get; set; } = new Collection<RecipientIdDto>();
    }
}
