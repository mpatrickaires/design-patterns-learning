namespace Facade.ExternalServices
{
    public class Repository
    {
        public bool EmailAlreadyInUse(string email)
        {
            // In a real code we would obviously have some logic for that, but we are not doing that
            // here
            Console.WriteLine($"Email {email} is available!");
            return false;
        }
    }
}
