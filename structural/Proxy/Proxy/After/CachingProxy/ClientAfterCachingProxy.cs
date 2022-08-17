using Proxy.After.CachingProxy.Proxy;

namespace Proxy.After.CachingProxy
{
    public static class ClientAfterCachingProxy
    {
        public static void Run()
        {
            Console.WriteLine("== After Caching Proxy ==");
            var youtube = new YoutubeIntegrationLibraryProxy();

            var video = youtube.GetVideo(42);
            var theSameVideo = youtube.GetVideo(42);
        }
    }
}
