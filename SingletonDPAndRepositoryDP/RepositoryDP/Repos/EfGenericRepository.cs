using SingletonDPAndRepositoryDP.RepositoryDP.Data;
using SingletonDPAndRepositoryDP.RepositoryDP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SingletonDPAndRepositoryDP.RepositoryDP.Repos
{
    public class EfGenericRepository<T, T1> : IRepository<T, T1>
        where T : class
        where T1 : struct
    {
        private readonly CompanyContext context= new CompanyContext();

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }
        public T GetById(T1 id)
        {
            return context.Find<T>(id);
        }
        public T Add(T entity)
        {
            return context.Add(entity).Entity;
        }

        #region Not implemented
        public int Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

      



        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
