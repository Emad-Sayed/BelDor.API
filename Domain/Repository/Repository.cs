using Core.Domain.Repository;
using Domain.Context;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace Domain.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected AppDbContext Context;
        public Repository(AppDbContext _Context)
        {
            Context = _Context;
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Any(predicate);
        }

        public int Count(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Count(predicate);
        }


        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().FirstOrDefault(predicate);
        }

        public (IEnumerable<TEntity>, int) TakeOrderByNumber(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, int>> order, int pageSize, int pageNumber)
        {
            var query = Context.Set<TEntity>().Where(predicate);
            var count = query.Count();
            var result = query.OrderBy(order).Skip((pageNumber - 1) * pageSize).Take(pageSize);
            return (result, count);
        }
        public (IEnumerable<TEntity>, int) TakeOrderByString(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, string>> order, int pageSize, int pageNumber)
        {
            var query = Context.Set<TEntity>().Where(predicate);
            var count = query.Count();
            var result = query.OrderBy(order).Skip((pageNumber - 1) * pageSize).Take(pageSize);
            return (result, count);
        }
    }
}
