using Proxy.Common.Services;

namespace Proxy.Before.VirtualProxy
{
    public static class ClientBeforeVirtualProxy
    {
        public static void Run()
        {
            Console.WriteLine("== Before Virtual Proxy ==");
            var random = new Random();
            var dbMonitor = new DbMonitor();

            var monitorWillBeUsed = random.Next(2) == 1;
            if (!monitorWillBeUsed)
            {
                Console.WriteLine("Client will NOT use the database monitor!");
                return;
            }
            Console.WriteLine("Client will use the database monitor!");
            dbMonitor.CheckStatus();
            dbMonitor.CountOpenConnections();
        }
    }
}
