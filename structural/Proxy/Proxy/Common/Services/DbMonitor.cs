using Proxy.Common.Services.Interfaces;

namespace Proxy.Common.Services
{
    public class DbMonitor : IDbMonitor
    {
        private readonly Random _random = new();

        public DbMonitor()
        {
            Console.Write("Establishing connection to database");
            var seconds = 0;
            while (true)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                seconds++;
                Console.Write('.');
                if (seconds == 3) break;
            }
            Console.WriteLine("\nConnection successfully established!");
        }

        public bool CheckStatus()
        {
            var status = _random.Next(2);
            if (status == 0)
            {
                Console.WriteLine("Database status is: DOWN");
                return false;

            }
            Console.WriteLine("Database status is: OK");
            return true;
        }

        public int CountOpenConnections()
        {
            var openConnections = _random.Next(1000);
            Console.WriteLine($"Number of open connections: {openConnections}");
            return openConnections;
        }
    }
}
