using CafeApp.Data.Models;

namespace CafeApp.Data.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        public Task<TEntity> GetById(int id);
        public IQueryable<TEntity> Get();
        public Task<int> Create(TEntity entity);
        public Task<TEntity> Update(TEntity entity);
        public Task<int> Delete(int id);
    }
}
