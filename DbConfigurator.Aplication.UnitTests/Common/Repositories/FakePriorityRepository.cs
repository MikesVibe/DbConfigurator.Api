﻿using DbConfigurator.Aplication.Contracts.Persistence;
using DbConfigurator.Model.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.UnitTests.Common.Repositories
{
    internal class FakePriorityRepository : IPriorityRepository
    {
        public Task<Priority> AddAsync(Priority entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Priority value)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Priority>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Priority?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Priority entity)
        {
            throw new NotImplementedException();
        }
    }
}
