using LibraryManagement.Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Infrastructure.Repository
{
    public interface IRepository<TEntity> where TEntity : class, IEntity<int, string>, new()
    {
        Task<TEntity> GetById(int id);
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
