﻿using DbConfigurator.Api.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Model.Entities.Core
{
    public class Region
    {
        [Required]
        public int Id { get; set; }

        public Area Area { get; set; }
        public int AreaId { get; set; }
        public BuisnessUnit BuisnessUnit { get; set; }
        public int BuisnessUnitId { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }

        public ICollection<DistributionInformation> DistributionInformations { get; set; }

    }
}
