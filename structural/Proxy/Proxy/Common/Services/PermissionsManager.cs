using Proxy.Common.Services.Interfaces;

namespace Proxy.Common.Services
{
    public class PermissionsManager : IPermissionsManager
    {
        public void GrantAdminPermissions(string userName)
        {
            Console.WriteLine($"Admin permissions granted to {userName}");
        }

        public void RevokeAdminPermissions(string userName)
        {
            Console.WriteLine($"Admin permissions revoked from {userName}");
        }
    }
}
