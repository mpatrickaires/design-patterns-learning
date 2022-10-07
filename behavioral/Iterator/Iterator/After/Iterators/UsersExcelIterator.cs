using ExcelDataReader;
using Iterator.After.IterableCollections;
using Iterator.After.Iterators.Interfaces;
using Iterator.Model;

namespace Iterator.After.Iterators
{
    public class UsersExcelIterator : IUsersIterator, IDisposable
    {
        private readonly UsersExcelCollection _usersExcelCollection;
        private readonly IExcelDataReader _reader;
        private User _userCache;

        public UsersExcelIterator(UsersExcelCollection usersExcelCollection)
        {
            _usersExcelCollection = usersExcelCollection;
            _reader = _usersExcelCollection.CreateReader();
            _reader.Read();
        }

        public User Current()
        {
            if (_userCache == null) _userCache = GetUserFromReader();
            return _userCache;
        }

        private User GetUserFromReader()
        {
            if (!HasMore()) return null;
            return new User
            {
                Name = _reader.GetString(0),
                Age = Convert.ToInt32(_reader.GetDouble(1)),
                Country = _reader.GetString(2),
            };
        }

        public bool HasMore() => !_reader.IsDBNull(0);

        public User Next()
        {
            _reader.Read();
            if (!HasMore()) return null;
            _userCache = GetUserFromReader();
            return _userCache;
        }

        public void Dispose()
        {
            _reader.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
