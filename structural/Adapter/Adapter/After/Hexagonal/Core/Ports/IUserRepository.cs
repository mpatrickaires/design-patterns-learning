using Adapter.After.Hexagonal.Core.Models;

namespace Adapter.After.Hexagonal.Core.Ports
{
    public interface IUserRepository
    {
        public void Save(User user);
        public IEnumerable<User> GetAll();
    }
}
