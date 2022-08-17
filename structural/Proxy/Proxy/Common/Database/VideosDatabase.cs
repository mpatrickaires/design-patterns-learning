using Proxy.Common.Models;

namespace Proxy.Common.Database
{
    public class VideosDatabase
    {
        private readonly List<Video> _videos = new();

        public VideosDatabase()
        {
            _videos.Add(new Video(42, "How to reach the answer to life, the universe and everything - Complete guide"));
            _videos.Add(new Video(13, "Friday the 13th - Was Jason really the villain?"));
            _videos.Add(new Video(9001, "Goku vs Nappa"));
        }

        public Video FindVideoById(int id)
        {
            Console.Write($"ID: {id} - Searching for video");

            var seconds = 0;
            while (true)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                seconds++;
                Console.Write('.');
                if (seconds == 3) break;
            }
            Console.WriteLine();

            return _videos.FirstOrDefault(v => v.Id == id);
        }
    }
}
