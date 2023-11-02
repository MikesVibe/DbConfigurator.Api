using AutoMapper;
using DbConfigurator.Application.Contracts.Features.Create;
using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Dtos;
using DbConfigurator.Application.Features.AreaFeature.Commands.Create;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.Common
{
    public class CreateCommandHandlerBase<TEntity, TEntityDto, TCreateCommand>
        where TEntity : class
        where TCreateCommand : ICreateCommand
    {
        protected readonly IRepository<TEntity> _repository;
        protected readonly IMapper _mapper;

        public CreateCommandHandlerBase(IRepository<TEntity> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public virtual async Task<Result<TEntityDto>> Handle(TCreateCommand command, CancellationToken cancellationToken)
        {
            var entityToAdd = _mapper.Map<TEntity>(command.CreateEntityDto);
            var result = await _repository.AddAsync(entityToAdd);
            if (result.IsFailed)
            {
                return Result.Fail($"Failed to create {nameof(TEntity)}.");
            }

            var dto = _mapper.Map<TEntityDto>(result);
            return dto;
        }
    }
}
