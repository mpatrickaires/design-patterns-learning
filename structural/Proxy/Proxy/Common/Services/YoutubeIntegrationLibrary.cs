using Proxy.Common.Database;
using Proxy.Common.Models;
using Proxy.Common.Services.Interfaces;

namespace Proxy.Common.Services
{
    public class YoutubeIntegrationLibrary : IYoutubeIntegrationLibrary
    {
        private VideosDatabase _videosDatabase = new();
        public Video GetVideo(int id)
        {
            var video = _videosDatabase.FindVideoById(id);

            var message = video != null
                ? $"Found the video: '{video.Name}'"
                : $"No video found with this ID!";
            Console.WriteLine(message);

            return video;
        }
    }
}
