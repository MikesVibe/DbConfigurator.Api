﻿using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.Country
{
    public class GetCountryDetailsQuery : IRequest<Result<CountryDto>>
    {
        public int CountryId { get; set; }
    }
}