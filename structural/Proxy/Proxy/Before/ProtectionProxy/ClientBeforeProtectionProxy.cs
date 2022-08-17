using Proxy.Common.Services;

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
