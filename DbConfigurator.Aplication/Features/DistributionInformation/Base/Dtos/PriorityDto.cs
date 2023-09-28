using DbConfigurator.Api.Services;

namespace DbConfigurator.Application.Features.DistributionInformation.Base.Dtos
{
    public class PriorityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
