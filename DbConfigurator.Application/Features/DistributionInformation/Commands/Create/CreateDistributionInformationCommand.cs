﻿using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;

namespace DbConfigurator.Application.Features.DistributionInformationFeature
{
    public class CreateDistributionInformationCommand : IRequest<Result<DistributionInformationDto>>
    {
        public DistributionInformationDto DistributionInformation { get; set; } = new DistributionInformationDto();
    }
}
