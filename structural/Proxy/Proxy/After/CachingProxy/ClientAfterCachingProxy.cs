using Proxy.After.CachingProxy.Proxy;

/*
 * Now, look at how elegantly we solved this situation: we have a class, which implements the same interface and contains the one doing the 
 * integration with Youtube. The only responsibility of this class is to intercept the execution of the method responsible of obtaining the videos
 * and do the following: 
 * - If the video exists in cache, retrieve it from there; if not, execute the original routine (in the wrapped class) and when the video is 
 *  returned, cache it for future use.
 * And that's it! By handing our proxy instance to the client, the benefits of caching come.
 * Even though we can't modify the original class, if it has an interface that we can work with, we can add some new behavior to it.
 */

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
