﻿using DbConfigurator.Application.Contracts.Features.GetDetail;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.CountriesFeature.Queries.GetDetails
{
    public class GetCountryDetailsQuery : IRequest<Result<CountryDto>>, IGetDetailQuery
    {
        public int Id { get; set; }
    }
}
