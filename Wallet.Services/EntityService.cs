using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Wallet.Data;
using Wallet.Data.Entities;
using Wallet.Services.Core;

namespace Wallet.Services
{
    public class EntityService<TEntity> : IEntityService<TEntity>
        where TEntity : BaseEntity
    {
        private readonly WalletContext _context;

        public EntityService(WalletContext context)
        {
            _context = context;
        }

        public async Task<TEntity> CreateAsync(TEntity entity, string userBy)
        {
            entity.CreationDate = entity.ModificationDate = DateTime.UtcNow;
            entity.Enable = true;
            entity.LastMdifiedBy = entity.CreatedBy = userBy;
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public void Delete(TEntity entity)
        {
            EntityEntry dbEntityEntry = _context.Entry(entity);
            dbEntityEntry.State = EntityState.Deleted;
        }

        public void Disable(TEntity entity)
        {
            entity.Enable = false;
            EntityEntry dbEntityEntry = _context.Entry(entity);
            dbEntityEntry.State = EntityState.Modified;
        }

        public async Task<IEnumerable<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().AsNoTracking()
                .Where(t => t.Enable).Where(expression).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().AsNoTracking()
                .Where(t => t.Enable).ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAndIncludeAsync(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>()
                .AsNoTracking().Where(t => t.Enable);

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return await query.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _context.Set<TEntity>().AsNoTracking()
                    .Where(t => t.Id.Equals(id)).FirstOrDefaultAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity, string userBy)
        {
            entity.ModificationDate = DateTime.UtcNow;
            entity.LastMdifiedBy = userBy;
            EntityEntry dbEntityEntry = _context.Entry(entity);
            dbEntityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<TEntity>> FindByConditionAndIncludeAsync(Expression<Func<TEntity, bool>> expression, 
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>()
                .AsNoTracking().Where(t => t.Enable).Where(expression);

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            return await query.ToListAsync();
        }
    }
}