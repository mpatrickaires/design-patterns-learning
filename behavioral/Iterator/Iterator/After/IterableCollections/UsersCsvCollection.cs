using Iterator.After.IterableCollections.Interfaces;
using Iterator.After.Iterators;
using Iterator.After.Iterators.Interfaces;

namespace Iterator.After.IterableCollections
{
    public class UsersCsvCollection : IIterableUsersCollection
    {
        private string[] _lines;

        public UsersCsvCollection(string path)
        {
            _lines = File.ReadAllLines(path);
        }

        public int Length() => _lines.Count();

        public string this[int index] => _lines[index];

        public IUsersIterator CreateIterator() => new UsersCsvIterator(this);
    }
}
