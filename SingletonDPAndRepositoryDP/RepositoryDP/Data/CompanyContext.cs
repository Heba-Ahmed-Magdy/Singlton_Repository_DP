using Microsoft.EntityFrameworkCore;
using SingletonDPAndRepositoryDP.RepositoryDP.Entities;

namespace SingletonDPAndRepositoryDP.RepositoryDP.Data
{
    //https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-5.0
    //https://www.entityframeworktutorial.net/efcore/entity-framework-core-console-application.aspx

    public class CompanyContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //.....UseSqlServer(....) need for this package Microsoft.EntityFrameworkCore.SqlServer
            //Microsoft.EntityFrameworkCore.Tools
            optionsBuilder.UseSqlServer(@"Server=.;Database=CompanyDB;Trusted_Connection=True;");

            //To reflect changes on DB
            /*
             * add-migration CreateCompanyDB
             * update-database
             */
        }
    }
}
