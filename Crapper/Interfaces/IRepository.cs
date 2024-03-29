﻿using System.Linq.Expressions;

namespace Crapper.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task Add(T entity);
        Task Update(T entity);
        void Delete(T entity);
        Task<T?> GetById(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        Task Save();
    }
}
