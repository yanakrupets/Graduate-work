using CafeApp.Data.Interfaces;
using CafeApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeApp.Data
{
    public class UnitOfWork<TContext> : IUnitOfWork where TContext : DbContext
    {
        private bool _disposed;
        private IDictionary<Type, object> _repos;
        public TContext DbContext { get; }

        public UnitOfWork(TContext context)
        {
            DbContext = context
               ?? throw new ArgumentNullException(nameof(context));
        }
        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : Entity
        {
            if (_repos == null)
            {
                _repos = new Dictionary<Type, object>();
            }

            var type = typeof(TEntity);
            if (!_repos.ContainsKey(type))
            {
                _repos[type] = new Repository<TEntity>(DbContext);
            }

            return (IRepository<TEntity>)_repos[type];
        }

        public int SaveChanges()
        {
            return DbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await DbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _repos?.Clear();

                    DbContext.Dispose();
                }
            }

            _disposed = true;
        }
    }
}
