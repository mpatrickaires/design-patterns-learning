namespace Proxy.Common.Services.Interfaces
{
    public interface IPermissionsManager
    {
        void GrantAdminPermissions(string userName);
        void RevokeAdminPermissions(string userName);
    }
}
