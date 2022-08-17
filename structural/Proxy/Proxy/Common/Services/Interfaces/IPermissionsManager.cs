namespace Proxy.Common.Services.Interfaces
{
    public interface IPermissionsManager
    {
        void GrantAdminPermissions(string user);
        void RevokeAdminPermissions(string user);
    }
}
