using DbConfigurator.Application.Contracts;
using DbConfigurator.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RegionFeature.Commands.Create
{
    public class CreateRegionDto : ICreateEntityDto
    {
        public int AreaId { get; set; }
        public int BusinessUnitId { get; set; }
        public int CountryId { get; set; }
    }
}
