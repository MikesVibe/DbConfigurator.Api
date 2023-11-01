using DbConfigurator.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
