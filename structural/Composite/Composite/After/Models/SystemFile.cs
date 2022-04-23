using Composite.After.Models.Interfaces;

namespace Composite.After.Models
{
    public class SystemFile : ISystemObject
    {
        public string Name { get; set; }
        public int Size { get; set; }

        public SystemFile(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public int GetTotalSize()
        {
            return Size;
        }
    }
}
