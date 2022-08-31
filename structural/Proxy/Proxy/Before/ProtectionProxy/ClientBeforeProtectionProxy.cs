using Proxy.Common.Services;

/*
 * Let's say we have a class that contains methods that will perform some sensitive operation, like the granting and revoking of admin permissions.
 * It would be good to add some protection layer to the access of this class, like a token validation operation; but, we may not have control over 
 * this piece of code, which could happen if this class is from third party libraries.
 * So, if we can't modify the original class for some reason, those methods will be exposed to any caller without any kind of protection.
 * If only we could create some intermediate class to do this protection...
 */

namespace Proxy.Before.ProtectionProxy
{
    public static class ClientBeforeProtectionProxy
    {
        public static void Run()
        {
            Console.WriteLine("== Before Protection Proxy ==");
            var permissionsManager = new PermissionsManager();

            var tonyStark = "tony.stark@email.com";
            var steveRogers = "steve.rogers@email.com";

            permissionsManager.GrantAdminPermissions(tonyStark);
            permissionsManager.RevokeAdminPermissions(steveRogers);
        }
    }
}
