using Proxy.Common.Services;
using Proxy.Common.Services.Interfaces;

namespace Proxy.After.ProtectionProxy.Proxy
{
    public class PermissionsManagerProxy : IPermissionsManager
    {
        private readonly PermissionsManager _permissionsManager = new();

        private readonly string _validToken = "Valid";
        private readonly string _providedToken;

        public PermissionsManagerProxy(string providedToken)
        {
            _providedToken = providedToken;
        }

        public void GrantAdminPermissions(string user)
        {
            if (_providedToken != _validToken) throw new InvalidOperationException("Invalid token!");
            _permissionsManager.GrantAdminPermissions(user);
        }

        public void RevokeAdminPermissions(string user)
        {
            if (_providedToken != _validToken) throw new InvalidOperationException("Invalid token!");
            _permissionsManager.RevokeAdminPermissions(user);
        }
    }
}
