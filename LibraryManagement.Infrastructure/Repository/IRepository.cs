using LibraryManagement.Infrastructure.Entity;
using System.Linq.Expressions;

namespace LibraryManagement.Infrastructure.Repository
{
    public interface IRepository<TEntity> where TEntity : class, IEntity<Guid, string>
    {
        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> GetAll();

        Task<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        Task<IEnumerable<TEntity>> GetWhere(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);

        void AddRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);

        void Delete(TEntity entit);
        void DeleteRange(IEnumerable<TEntity> entities);
    }
}
