using DbConfigurator.Application.Dtos;

namespace DbConfigurator.Application.Features.DistributionInformationFeature.Queries.GetDistributionInformationDetails
{
    public class DistributionInformationDetails
    {
        public int Id { get; init; }
        public RegionDto Region { get; set; } = default!;
        public PriorityDto Priority { get; set; } = default!;
        public List<RecipientDto> RecipientsTo { get; set; } = new();
        public List<RecipientDto> RecipientsCc { get; set; } = new();
    }
}
