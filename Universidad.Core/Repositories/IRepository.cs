﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Core.Repositories
{
        public interface IRepository<TEntity> where TEntity : class
        {
            ValueTask<TEntity> GetByIdAsync(int id);
            Task<IEnumerable<TEntity>> GetAllAsync();
            IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
            Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
            Task AddAsync(TEntity entity);
            void Update(TEntity entity);
            Task AddRangeAsync(IEnumerable<TEntity> entities);
            void Remove(TEntity entity);
            void RemoveRange(IEnumerable<TEntity> entities);
        }
    
}
