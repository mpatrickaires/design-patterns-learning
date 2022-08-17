using Proxy.After.VirtualProxy.Proxy;

namespace Proxy.After.VirtualProxy
{
    public static class ClientAfterVirtualProxy
    {
        public static void Run()
        {
            Console.WriteLine("== After Virtual Proxy ==");
            var random = new Random();
            var dbMonitor = new DbMonitorProxy();

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
