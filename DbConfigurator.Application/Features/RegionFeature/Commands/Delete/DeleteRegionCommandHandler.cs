using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.DistributionInformationFeature.Commands.Delete;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.RegionFeature.Commands.Delete
{
    public class DeleteRegionCommandHandler : IRequestHandler<DeleteRegionCommand, Result<RegionDto>>
    {
        private readonly IRegionRepository _regionRepository;
        private readonly IMapper _mapper;

        public DeleteRegionCommandHandler(
            IRegionRepository regionRepository,
            IMapper mapper)
        {
            _regionRepository = regionRepository;
            _mapper = mapper;
        }

        public async Task<Result<RegionDto>> Handle(DeleteRegionCommand request, CancellationToken cancellationToken)
        {
            var entity = await _regionRepository.GetByIdAsync(request.RegionId);
            if (entity == null)
            {
                return Result.Fail("No istnace of region object with specified Id is present in database.");
            }

            await _regionRepository.DeleteAsync(entity);
            var deletedEntity = _mapper.Map<RegionDto>(entity);

            return Result.Ok(deletedEntity);
        }
    }
}
