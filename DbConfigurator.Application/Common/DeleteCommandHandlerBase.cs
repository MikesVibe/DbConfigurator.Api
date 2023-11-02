using AutoMapper;
using DbConfigurator.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbConfigurator.Application.Features.AreaFeature.Commands.Delete;
using FluentResults;
using DbConfigurator.Application.Contracts.Features.Delete;

namespace DbConfigurator.Application.Common
{
    public class DeleteCommandHandlerBase<TEntity, TEntityDto, TDeleteCommand>
    where TEntity : class
    where TDeleteCommand : IDeleteCommand
    {
        protected readonly IRepository<TEntity> _repository;

        public DeleteCommandHandlerBase(IRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public async Task<Result> Handle(TDeleteCommand command, CancellationToken cancellationToken)
        {
            var entity = await _repository.GetByIdAsync(command.Id);
            if (entity == null)
            {
                return Result.Fail($"No instance of {nameof(TEntity)} object with specified Id is present in database.");
            }

            await _repository.DeleteAsync(entity);
            return Result.Ok();
        }
    }
}
