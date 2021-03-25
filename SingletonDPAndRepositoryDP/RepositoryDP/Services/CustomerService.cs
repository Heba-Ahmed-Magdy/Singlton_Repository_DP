using SingletonDPAndRepositoryDP.RepositoryDP.Entities;
using SingletonDPAndRepositoryDP.RepositoryDP.Interfaces;
using SingletonDPAndRepositoryDP.RepositoryDP.Repos;
using System.Collections.Generic;
using System.Linq;

namespace SingletonDPAndRepositoryDP.RepositoryDP.Services
{
    public class CustomerService
    {
        private readonly IRepository<Customer, long> repos = new EfGenericRepository<Customer, long>();

        public List<Customer> GetAll()
        {
            return repos.GetAll().ToList();
        }
        public Customer Add(Customer customer)
        {
            var _customer= repos.Add(customer);
            repos.SaveChanges();
            return _customer;
        }
    }
}
