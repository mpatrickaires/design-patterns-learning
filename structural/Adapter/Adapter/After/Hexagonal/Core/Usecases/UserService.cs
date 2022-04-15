using Adapter.After.Hexagonal.Core.Models;
using Adapter.After.Hexagonal.Core.Ports;

namespace Adapter.After.Hexagonal.Core.Usecases
{
    public class UserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void SaveUser(User user)
        {
            bool alreadyUsedEmail = _userRepository.GetAll().Any(u => u.Email.ToLower().Equals(user.Email.ToLower()));

            if (alreadyUsedEmail) throw new ArgumentException("E-mail already in use.");

            _userRepository.Save(user);
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetAll();
        }
    }
}
