using Proxy.Common.Services;

/*
 * Imagine we have a class that connects to a database to do some monitoring job, like checking the
 * status and open connections. 
 * We will always have an object of this class available to do its job, however a problem is that
 * the class connects to the database as soon as it is instantiated, that is, this connection
 * happens at the constructor.
 * In our scenario, establishing a connection to a database is a very 
 * demanding task, that takes some time to complete, basically freezing the application.
 * This much likely causes an unecessary overhead, as the user would have to always wait the
 * connection completion everytime the application is started, this even if no operation envolving
 * this monitor is done.
 * 
 * But... imagine if we could do a way to delay the call to this class constructor to only when
 * we indeed call a method: this is what we'll see at the 'After' example.
 */

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
