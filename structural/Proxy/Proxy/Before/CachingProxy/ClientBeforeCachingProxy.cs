using Proxy.Common.Services;

namespace Proxy.Before.CachingProxy
{
    public static class ClientBeforeCachingProxy
    {
        public static void Run()
        {
            Console.WriteLine("== Before Caching Proxy ==");
            var youtube = new YoutubeIntegrationLibrary();

            var video = youtube.GetVideo(42);
            var theSameVideo = youtube.GetVideo(42);
        }
    }
}
