using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.BusinessUnitFeature
{
    public class UpdateBusinessUnitCommand : IRequest<Result<BusinessUnitDto>>
    {
        public BusinessUnitDto BusinessUnit { get; set; } = new BusinessUnitDto();
    }
}
