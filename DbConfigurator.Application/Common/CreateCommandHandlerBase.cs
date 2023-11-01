﻿using AutoMapper;
using DbConfigurator.Application.Contracts;
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
            var createdEntity = await _repository.AddAsync(entityToAdd);
            if (createdEntity is null)
                return Result.Fail($"Failed to create {nameof(TEntity)}.");

            var result = _mapper.Map<TEntityDto>(createdEntity);
            return result;
        }
    }
}