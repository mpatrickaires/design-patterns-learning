using Proxy.Common.Models;
using Proxy.Common.Services;
using Proxy.Common.Services.Interfaces;

namespace Proxy.After.CachingProxy.Proxy
{
    public class YoutubeIntegrationLibraryProxy : IYoutubeIntegrationLibrary
    {
        private readonly YoutubeIntegrationLibrary _youtubeIntegrationLibrary = new();

        private readonly Dictionary<int, Video> _videoCache = new();

        public Video GetVideo(int id)
        {
            Video video;

            if (_videoCache.ContainsKey(id))
            {
                video = _videoCache[id];
                Console.WriteLine($"[CACHE] Found the video: '{video.Name}'!");
                return video;
            }

            video = _youtubeIntegrationLibrary.GetVideo(id);
            _videoCache[id] = video;
            return video;
        }
    }
}
