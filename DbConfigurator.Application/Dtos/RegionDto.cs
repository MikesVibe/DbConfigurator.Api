namespace DbConfigurator.Application.Dtos
{
    public class RegionDto
    {
        public int Id { get; init; }
        public AreaDto Area { get; set; } = default!;
        public BusinessUnitDto BusinessUnit { get; set; } = default!;
        public CountryDto Country { get; set; } = default!;
    }
}
