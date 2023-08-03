using DbConfigurator.Api.Services;

namespace DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformationList.Dtos
{
    public class PriorityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
