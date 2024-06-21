using DbConfigurator.Application.Contracts.Features.Create;

namespace DbConfigurator.Application.Features.RegionFeature.Commands.Create
{
    public class CreateRegionDto : ICreateEntityDto
    {
        public int AreaId { get; set; }
        public int BusinessUnitId { get; set; }
        public int CountryId { get; set; }
    }
}
