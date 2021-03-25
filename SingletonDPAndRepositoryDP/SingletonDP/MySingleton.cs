namespace SingletonDPAndRepositoryDP.singletonDP
{
    public class MySingleton
    {
        private static MySingleton _instance;
        private static object obj = new object();
        public static MySingleton Instance
        {
            get
            {
                System.Console.WriteLine("From Property");
                lock(obj)
                {
                    return _instance ??= new MySingleton();
                }
            }
        }
        private MySingleton()
        { System.Console.WriteLine("From Ctor"); }
    }
}
