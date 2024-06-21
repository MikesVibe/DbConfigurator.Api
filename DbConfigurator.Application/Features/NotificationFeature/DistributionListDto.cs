using DbConfigurator.Application.Dtos;

namespace DbConfigurator.Application.Features.NotificationFeature
{
    public class DistributionListDto
    {
        public IEnumerable<RecipientDto> RecipientsTo { get; set; } = Enumerable.Empty<RecipientDto>();
        public IEnumerable<RecipientDto> RecipientsCc { get; set; } = Enumerable.Empty<RecipientDto>();
    }
}
