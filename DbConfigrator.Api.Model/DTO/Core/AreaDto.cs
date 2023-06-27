﻿using DbConfigurator.Api.Services;
using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Model.DTOs.Core
{
    public class AreaDto : IEntityDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
    }
}
