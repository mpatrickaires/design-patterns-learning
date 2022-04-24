using Facade.ExternalServices;
using Facade.Models;

namespace Facade.After.Facades
{
    public class UserFacade
    {
        public void RegisterUser(User user, string password)
        {
            Repository repository = new Repository();
            Registration registration = new Registration();
            Security security = new Security();

            if (repository.EmailAlreadyInUse(user.Email))
            {
                throw new Exception("Email already in use!");
            }

            string encryptedPassword = security.EncryptPassword(password);
            registration.NewUser(user, encryptedPassword);
        }

        public void Login(User user, string password)
        {
            Security security = new Security();
            Login login = new Login();

            string encryptedPassword = security.EncryptPassword(password);
            login.Access(user, encryptedPassword);
        }
    }
}
