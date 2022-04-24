using Facade.Models;

namespace Facade.ExternalServices
{
    public class Registration
    {
        public void NewUser(User user, string password)
        {
            Console.WriteLine($"New user registered successfully! Name: {user.Name}, Email: {user.Email}");
        }
    }
}
