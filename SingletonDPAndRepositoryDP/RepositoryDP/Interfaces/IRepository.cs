using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SingletonDPAndRepositoryDP.RepositoryDP.Interfaces
{
    public interface IRepository<T,T1> 
    {
        T Add(T entity);
        T Update(T entity);
        int Delete(long id);
        T GetById(T1 id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void SaveChanges();
    }
}