using Proxy.Common.Services;

/*
 * Imagine the following scenario: we are using a third-party library capable of integrating with Youtube and returning videos by a given ID.
 * It does this by connecting to Youtube, searching for the video, downloading it, and in the end effectively returning it to the caller. 
 * This, as can be seen, is a very slow process.
 * If it wasn't enough, if we keep asking for the same video, it will do this routine every time! This generates an excessive overhead that
 * we could overcome simply by caching those videos, retrieving them from there for future uses.
 * However, as many of the examples here, we simply don't have access to modify this code (which is honestly a great problem that the proxy is 
 * able to solve).
 */

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
