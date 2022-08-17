using Proxy.After.ProtectionProxy.Proxy;

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
