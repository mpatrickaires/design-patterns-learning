namespace Proxy.Common.Services.Interfaces
{
    public interface IDbMonitor
    {
        bool CheckStatus();
        int CountOpenConnections();
    }
}
