using Facade.Models;

namespace Facade.ExternalServices
{
    public class Security
    {
        public string EncryptPassword(string password)
        {
            Console.WriteLine("Password encrypted successfully!");

            // In a real code we would obviously have some logic here, but let's just return the same
            // password
            return password;
        }

        public void TwoFactorAuthentication(User user)
        {
            Console.WriteLine($"Two Factor Authentication for {user.Email} done successfully!");
        }
    }
}
