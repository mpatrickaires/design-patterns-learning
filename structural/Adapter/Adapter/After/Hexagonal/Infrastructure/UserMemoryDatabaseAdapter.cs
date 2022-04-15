using Adapter.After.Hexagonal.Core.Models;
using Adapter.After.Hexagonal.Core.Ports;

namespace Adapter.After.Hexagonal.Infrastructure
{
    public class UserMemoryDatabaseAdapter : IUserRepository
    {
        private Dictionary<string, User> _memoryUsers = new Dictionary<string, User>();

        public void Save(User user)
        {
            _memoryUsers.Add(user.Email, user);
        }

        public IEnumerable<User> GetAll()
        {
            return _memoryUsers.Values;
        }
    }
}
