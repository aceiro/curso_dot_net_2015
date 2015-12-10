using System;
using System.Linq;
using System.Linq.Expressions;

namespace Camisaria.Portal.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> expression);

        TEntity GetById(int id);

        void Add(TEntity obj);

        void Update(TEntity obj);

        void Delete(int id);

        void Delete(TEntity obj);
    }
}
