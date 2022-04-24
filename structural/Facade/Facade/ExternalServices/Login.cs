using Facade.Models;

namespace Facade.ExternalServices
{
    public class Login
    {
        public void Access(User user, string password)
        {
            Console.WriteLine($"Logged in successfully! Name: {user.Name}, Email: {user.Email}");
        }
    }
}
