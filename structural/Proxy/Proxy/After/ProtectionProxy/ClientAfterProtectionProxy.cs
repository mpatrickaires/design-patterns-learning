using Proxy.After.ProtectionProxy.Proxy;

/*
 * So, now we have a Protection Proxy! This class will intermediate the access to the wrapped class (the original we wanted to protect) and will
 * require a token to be provided; it will then validate the token, throwing an exception when is not validate and effectively blocking those
 * methods.
 * In short, we will have the proxy that will contain the class with the original methods while implementing the same interface. The 
 * implementation of the interface is basically a layer of security (for the methods where needed) that will act before calling the method
 * of the wrapped class, which will actually do the logic.
 * An instance of the proxy will be provided to the client, acting as our security to the access.
 */

namespace Proxy.After.ProtectionProxy
{
    public static class ClientAfterProtectionProxy
    {
        public static void Run()
        {
            Console.WriteLine("== Before Protection Proxy ==");
            var random = new Random();

            string token;
            var usingValidToken = random.Next(2) == 1;
            if (usingValidToken)
            {
                Console.WriteLine("Using valid token!");
                token = "Valid";
            }
            else
            {
                Console.WriteLine("Using invalid token!");
                token = "Invalid";
            }

            var permissionsManager = new PermissionsManagerProxy(token);

            var tonyStark = "tony.stark@email.com";
            var steveRogers = "steve.rogers@email.com";

            try
            {
                permissionsManager.GrantAdminPermissions(tonyStark);
                permissionsManager.RevokeAdminPermissions(steveRogers);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"An error ocurred while changing the permissions: {e.Message}");
            }
        }
    }
}
