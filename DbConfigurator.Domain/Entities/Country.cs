﻿using DbConfigurator.Api.Services;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Domain.Model.Entities
{
    public class Country : IEntity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string CountryName { get; set; } = string.Empty;
        [Required]
        [MaxLength(3)]
        public string CountryCode { get; set; } = string.Empty;
        public ICollection<Region> Regions { get; set; } = new Collection<Region>();
    }
}
