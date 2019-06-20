﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Wallet.Data.Entities;

namespace Wallet.Services.Core
{
    public interface IEntityService<TEntity> where TEntity : BaseEntity
    {
        /// <summary>
        /// Create record
        /// </summary>
        /// <param name="entity">Record to create</param>
        void Create(TEntity entity);

        /// <summary>
        /// Update record
        /// </summary>
        /// <param name="entity">Record to update</param>
        void Update(TEntity entity);

        /// <summary>
        /// Delete record
        /// </summary>
        /// <param name="entity">Record to delete</param>
        void Delete(TEntity entity);

        /// <summary>
        /// Disable entity
        /// </summary>
        /// <param name="entity">Entity to disable</param>
        void Disable(TEntity entity);

        /// <summary>
        /// Get record by id
        /// </summary>
        /// <param name="id">record id</param>
        /// <returns></returns>
        Task<TEntity> GetByIdAsync(Guid id);

        /// <summary>
        /// Get all records
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> GetAllAsync();

        /// <summary>
        /// Get records that match
        /// some criteria
        /// </summary>
        /// <param name="expression">Condition to filter records</param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression);

        /// <summary>
        /// Get records that match
        /// some criteria with relations
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> FindByConditionAndIncludeAsync(Expression<Func<TEntity, bool>> expression, 
            params Expression<Func<TEntity, object>>[] includeProperties);

        /// <summary>
        /// Get all records with relations
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> GetAllAndIncludeAsync(params Expression<Func<TEntity, object>>[] includeProperties);
    }
}
