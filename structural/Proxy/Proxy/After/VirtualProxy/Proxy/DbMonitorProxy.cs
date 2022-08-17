using Proxy.Common.Services;
using Proxy.Common.Services.Interfaces;

namespace Proxy.After.VirtualProxy.Proxy
{
    public class DbMonitorProxy : IDbMonitor
    {
        private DbMonitor _dbMonitor;

        public bool CheckStatus()
        {
            if (_dbMonitor == null) _dbMonitor = new DbMonitor();
            return _dbMonitor.CheckStatus();
        }

        public int CountOpenConnections()
        {
            if (_dbMonitor == null) _dbMonitor = new DbMonitor();
            return _dbMonitor.CountOpenConnections();
        }
    }
}
