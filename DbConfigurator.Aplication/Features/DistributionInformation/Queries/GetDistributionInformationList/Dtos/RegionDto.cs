using DbConfigurator.Api.Services;

namespace DbConfigurator.Aplication.Features.DistributionInformation.Queries.GetDistributionInformationList.Dtos
{
    public class RegionDto
    {
        public int Id { get; init; }
        public AreaDto Area { get; set; } = default!;
        public BuisnessUnitDto BuisnessUnit { get; set; } = default!;
        public CountryDto Country { get; set; } = default!;
    }
}
