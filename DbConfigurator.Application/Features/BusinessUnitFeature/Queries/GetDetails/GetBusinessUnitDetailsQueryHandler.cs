using AutoMapper;
using DbConfigurator.Application.Common;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.AreaFeature;
using DbConfigurator.Domain.Model.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.BusinessUnitFeature.Queries.GetDetails
{
    public class GetBusinessUnitDetailsQueryHandler : GetDetailQueryHandlerBase<BusinessUnit, BusinessUnitDto, GetBusinessUnitDetailsQuery>,
        IRequestHandler<GetBusinessUnitDetailsQuery, Result<BusinessUnitDto>>
    {
        public GetBusinessUnitDetailsQueryHandler(
            IBusinessUnitRepository businessUnitRepository,
            IMapper mapper) : base(businessUnitRepository, mapper)
        {
        }
    }
}
