﻿using DbConfigurator.Application.Contracts.Features.Create;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.AreaFeature.Commands.Create
{
    public class CreateAreaDto : ICreateEntityDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
    }
}
