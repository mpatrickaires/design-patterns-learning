using Facade.ExternalServices;
using Facade.Models;

/*
 * Let's suppose we have an application that consumes a 3rd-party library that helps us with the 
 * proccess of creating and loggin in an user (represented at the ExternalServices folder).
 * To take advantage of the benefits of this library, we would need to implement a code that is tightly
 * coupled to its service classes and also do all the logic we want for this routine. It's a bad 
 * practice to do that at the client (as shown below), because our code will be too much coupled to the
 * library we use now; so, if in the future we wanted to change the library we use, it would be a huge 
 * headache.
 */

namespace Facade.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            Console.WriteLine("== Before ==");

            Repository repository = new Repository();
            Registration registration = new Registration();
            Security security = new Security();
            Login login = new Login();

            User user = new User();
            user.Email = "johndoe@test.com";
            user.Name = "John Doe";

            if (repository.EmailAlreadyInUse(user.Email))
            {
                throw new Exception("Email already in use!");
            }

            string passwordRegistration = security.EncryptPassword("abc123");
            registration.NewUser(user, passwordRegistration);

            string passwordLogin = security.EncryptPassword("abc123");
            login.Access(user, passwordLogin);
        }
    }
}
