using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CentralDeNegocio.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Create(TEntity model);

        List<TEntity> Create(List<TEntity> model);

        bool Update(TEntity model);

        bool Update(List<TEntity> model);

        public bool Delete(TEntity model);

        bool Delete(params object[] keys);

        bool Delete(Expression<Func<TEntity, bool>> where);

        int Save();

        TEntity Find(params object[] keys);

        TEntity Find(Expression<Func<TEntity, bool>> where);

        TEntity Find(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, object> includes);

        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> where);

        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, object> includes);

        Task<TEntity> CreateAsync(TEntity model);

        Task<bool> UpdateAsync(TEntity model);

    }
}
