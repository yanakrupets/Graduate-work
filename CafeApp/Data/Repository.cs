using CafeApp.Data.Interfaces;
using CafeApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeApp.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity: Entity
    {
        protected DbContext _dbContext;
        protected DbSet<TEntity> _dbSet;
        public Repository(DbContext context)
        {
            _dbContext = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task<int> Create(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity.Id;
        }

        public async Task<int> Delete(int id)
        {
            var model = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
            if(model == null)
            {
                throw new Exception($"Model with id: {id} was not found");
            }
            _dbContext.Remove(model);
            await _dbContext.SaveChangesAsync();
            return model.Id;
        }

        public IQueryable<TEntity> Get()
        {
            IQueryable<TEntity> query = _dbSet;
            return query;
        }

        public async Task<TEntity> GetById(int id)
        {
            IQueryable<TEntity> query = _dbSet;

            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _dbSet.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
