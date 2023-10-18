using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Features.AreaFeature.Commands.Update
{
    public class UpdateAreaCommandHandler : IRequestHandler<UpdateAreaCommand, Result<AreaDto>>
    {
        private readonly IAreaRepository _areaRepository;
        private readonly IMapper _mapper;

        public UpdateAreaCommandHandler(
            IAreaRepository areaRepository,
            IMapper mapper)
        {
            _areaRepository = areaRepository;
            _mapper = mapper;
        }

        public async Task<Result<AreaDto>> Handle(UpdateAreaCommand request, CancellationToken cancellationToken)
        {
            var entity = await _areaRepository.GetByIdAsync(request.Area.Id);
            if (entity == null)
            {
                return Result.Fail("No istnace of area object with specified Id is present in database.");
            }

            _mapper.Map(request.Area, entity);

            await _areaRepository.UpdateAsync(entity);
            return Result.Ok();
        }
    }
}
