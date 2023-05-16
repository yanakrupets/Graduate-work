using CafeApp.Data.Models;

namespace CafeApp.Data.Interfaces
{
    public interface IUnitOfWork
    {
        public IRepository<TEntity> GetRepository<TEntity>() where TEntity: Entity;

        Task<int> SaveChangesAsync();
        int SaveChanges();
    }
}
