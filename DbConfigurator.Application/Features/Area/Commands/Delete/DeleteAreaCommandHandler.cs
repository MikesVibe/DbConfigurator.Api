using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.DistributionInformationFeature;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.AreaFeature
{
    public class DeleteAreaCommandHandler : IRequestHandler<DeleteAreaCommand, Result>
    {
        private readonly IAreaRepository _areaRepository;
        private readonly IMapper _mapper;

        public DeleteAreaCommandHandler(
            IAreaRepository areaRepository,
            IMapper mapper)
        {
            _areaRepository = areaRepository;
            _mapper = mapper;
        }

        public async Task<Result> Handle(DeleteAreaCommand request, CancellationToken cancellationToken)
        {
            var entity = await _areaRepository.GetByIdAsync(request.AreaId);
            if (entity == null)
            {
                return Result.Fail("No instance of area object with specified Id is present in database.");
            }

            await _areaRepository.DeleteAsync(entity);
            return Result.Ok();
        }
    }
}
