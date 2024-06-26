﻿using DbConfigurator.Api.Services;
using DbConfigurator.Application.Contracts.Persistence;
using FluentResults;

namespace DbConfigurator.Application.UnitTests.Common.Repositories
{
    public abstract class FakeBaseRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        public FakeBaseRepository()
        {
            Entities = InitializeEntities();
        }
        public IEnumerable<TEntity> Entities { get; set; } = new List<TEntity>();
        public bool ExistsAsyncReturnValue { get; private set; }

        public async Task<Result<TEntity>> AddAsync(TEntity entity)
        {
            await Task.Delay(0);
            return entity;
        }

        public Task DeleteAsync(TEntity value)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            await Task.Delay(0);
            return ExistsAsyncReturnValue;
        }


        public void ExistsAsyncReturns(bool retrunValue)
        {
            ExistsAsyncReturnValue = retrunValue;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            await Task.Delay(0);
            return Entities;
        }

        public async Task<TEntity?> GetByIdAsync(int id)
        {
            var list = await GetAllAsync();
            return list.FirstOrDefault(d => d.Id == id);
        }

        public Task<bool> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }


        protected abstract IEnumerable<TEntity> InitializeEntities();
    }
}
