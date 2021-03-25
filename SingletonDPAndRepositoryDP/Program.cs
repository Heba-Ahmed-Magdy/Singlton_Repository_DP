using SingletonDPAndRepositoryDP.RepositoryDP.Entities;
using SingletonDPAndRepositoryDP.RepositoryDP.Services;
using SingletonDPAndRepositoryDP.singletonDP;
using System;

namespace SingletonDPAndRepositoryDP
{
    //https://docs.microsoft.com/en-us/dotnet/api/system.enum.isdefined?view=net-5.0
    //https://stackoverflow.com/questions/1113627/is-there-a-create-new-folder-in-current-project-keyboard-shortcut-for-visual-stu
    class Program
    {
        static void Main(string[] args)
        {
            #region [Singleton DP]
            var mySingleton1 = MySingleton.Instance;
            var mySingleton2 = MySingleton.Instance;
            var mySingleton3 = MySingleton.Instance;
            Console.WriteLine($"{mySingleton1 == mySingleton2}");
            #endregion

            #region [Repository DP]

            var customerService = new CustomerService();
            var customer = new Customer { Name="Hebbbbbbbbbbbbbaaaa" };
            customerService.Add(customer);

            customerService.GetAll().ForEach(x => Console.WriteLine($"{x.Id} :: {x.Name}"));

            #endregion
        }
    }
}
