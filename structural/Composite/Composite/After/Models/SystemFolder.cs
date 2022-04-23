using Composite.After.Models.Interfaces;

namespace Composite.After.Models
{
    public class SystemFolder : ISystemObject
    {
        public string Name { get; set; }
        private List<ISystemObject> _children = new List<ISystemObject>();

        public SystemFolder(string name)
        {
            Name = name;
        }

        public void Add(params ISystemObject[] systemObject)
        {
            _children.AddRange(systemObject);
        }

        public int GetTotalSize()
        {
            var totalSize = 0;

            foreach (var children in _children)
            {
                totalSize += children.GetTotalSize();
            }

            return totalSize;
        }
    }
}
