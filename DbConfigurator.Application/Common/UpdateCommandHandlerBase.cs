using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using DbConfigurator.Application.Features.AreaFeature.Commands.Update;
using DbConfigurator.Application.Contracts.Features.Update;

namespace DbConfigurator.Application.Common
{
    public class UpdateCommandHandlerBase<TEntity, TEntityDto, TUpdateCommand>
        where TEntity : class
        where TUpdateCommand : IUpdateCommand
    {
        protected readonly IRepository<TEntity> _repository;
        protected readonly IMapper _mapper;

        public UpdateCommandHandlerBase(IRepository<TEntity> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Result> Handle(TUpdateCommand command, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByIdAsync(command.UpdateEntityDto.Id);
            if (entity == null)
            {
                return Result.Fail($"No instance of {nameof(TEntity)} object with specified Id is present in database.");
            }

            _mapper.Map(command.UpdateEntityDto, entity);

            var result = await _repository.UpdateAsync(entity);
            if (result)
            {
                return Result.Ok();
            }
            else
            {
                return Result.Fail($"Update of {nameof(TEntity)} failed.");
            }
        }
    }
}
