using Proxy.Common.Models;

namespace Proxy.Common.Services.Interfaces
{
    public interface IYoutubeIntegrationLibrary
    {
        Video GetVideo(int id);
    }
}
