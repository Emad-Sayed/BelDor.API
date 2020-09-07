using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Domain.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Remove(TEntity entity);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
        int Count(Expression<Func<TEntity, bool>> predicate);
        bool Any(Expression<Func<TEntity, bool>> predicate);
        (IEnumerable<TEntity>, int) TakeOrderByNumber(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, int>> order, int pageSize, int pageNumber);
        (IEnumerable<TEntity>, int) TakeOrderByString(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, string>> order, int pageSize, int pageNumber);
    }
}
