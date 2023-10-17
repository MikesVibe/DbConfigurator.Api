using DbConfigurator.Api.Services;

namespace DbConfigurator.Domain.Model.Entities
{
    public class RecipientGroupTo : IEntity
    {
        public int Id { get; }
        public int RecipientId { get; set; }
        public Recipient Recipient { get; set; } = new Recipient();
        public int DistributionInformationId { get; set; }
        public DistributionInformation DistributionInformation { get; set; } = new DistributionInformation();
    }
}
