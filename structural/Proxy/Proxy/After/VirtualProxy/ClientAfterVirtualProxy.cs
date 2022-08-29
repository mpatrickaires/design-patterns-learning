using Proxy.After.VirtualProxy.Proxy;

/*
 * Now, let's take a look at this example: a new class was created, the DbMonitorProxy, which implements
 * the same interface as the original DbMonitor. This proxy contains a wrapped object of DbMonitor,
 * to whom all the methods call will be delegated.
 * The big point is, our proxy will only instantiate its wrapped object when a method is indeed called,
 * but never before. This allows us to create this object without having to wait the overhead it does
 * of connecting to a database, only doing so if our user indeed goes to a routine where this is 
 * necessary.
 * This way, we implemented what is called a 'lazy loading', that is, a class is only instantiated when
 * some method of it is really called. This is a great way to avoid demanding tasks that happens at the 
 * constructor.
 */

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
