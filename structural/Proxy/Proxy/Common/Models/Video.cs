namespace Proxy.Common.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Video(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
