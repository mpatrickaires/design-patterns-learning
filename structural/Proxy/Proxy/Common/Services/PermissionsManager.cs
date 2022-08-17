using Proxy.Common.Services.Interfaces;

namespace Proxy.Common.Services
{
    public class PermissionsManager : IPermissionsManager
    {
        public void GrantAdminPermissions(string user)
        {
            Console.WriteLine($"Admin permissions granted to {user}");
        }

        public void RevokeAdminPermissions(string user)
        {
            Console.WriteLine($"Admin permissions revoked from {user}");
        }
    }
}
