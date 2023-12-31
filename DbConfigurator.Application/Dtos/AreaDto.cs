﻿using System.ComponentModel.DataAnnotations;

namespace DbConfigurator.Application.Dtos
{
    public class AreaDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
    }
}
