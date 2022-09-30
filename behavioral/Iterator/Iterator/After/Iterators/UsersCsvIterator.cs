using Iterator.After.IterableCollections;
using Iterator.After.Iterators.Interfaces;
using Iterator.Model;

namespace Iterator.After.Iterators
{
    public class UsersCsvIterator : IUsersIterator
    {
        private readonly UsersCsvCollection _collection;
        private int _index;
        private User _userCache;

        public UsersCsvIterator(UsersCsvCollection collection)
        {
            _collection = collection;
        }

        public User Current()
        {
            if (_userCache == null) _userCache = GetUserFromLine(_collection[_index]);

            return _userCache;
        }

        public bool IsDone() => _index > _collection.Length();

        public User Next()
        {
            if (!IsDone()) return null;

            _index += 1;
            _userCache = GetUserFromLine(_collection[_index]);

            return _userCache;
        }

        private User GetUserFromLine(string line)
        {
            string[] fields = line.Split(";");
            return new User
            {
                Name = fields[0],
                Age = int.Parse(fields[1]),
                Country = fields[2],
            };
        }
    }
}
