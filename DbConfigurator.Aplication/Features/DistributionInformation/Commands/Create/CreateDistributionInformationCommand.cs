using DbConfigurator.Application.Features.DistributionInformation.Base.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.DistributionInformation.Commands.Create
{
    public class CreateDistributionInformationCommand : IRequest<bool>
    {
        public DistributionInformationDto DistributionInformation { get; set; } = new DistributionInformationDto();
    }
}
