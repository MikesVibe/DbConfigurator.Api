using DbConfigurator.Application.Contracts.Features.Update;

namespace DbConfigurator.Application.Features.RegionFeature.Commands.Update
{
    public class UpdateRegionDto : IUpdateEntityDto
    {
        public int Id { get; set; }
        public int AreaId { get; set; }
        public int BusinessUnitId { get; set; }
        public int CountryId { get; set; }
    }
}
