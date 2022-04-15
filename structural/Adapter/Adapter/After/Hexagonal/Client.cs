using Adapter.After.Hexagonal.Application;

/*
 * This is an example of the Adapter using the Hexagonal architeture.
 * Here, the Core is the main part of the project and has classes that has no dependencies with anything
 * that is outside the Core. To achieve that, Ports are created to have a communication between the 
 * outer world and the Core, those Ports are abstractions that must be implemented to make the Usecases
 * be able to execute methods around the Models.
 * After that is defined, at the Infrastructure we have our Adapter: it implements any abstraction that
 * is defined at the Ports and thus is responsible for being the connection between what is inside the
 * Core with what is outside. After implementing the abstractions, the Adapter is then used as the
 * object that will be called by the Usecases that by itself is called by the Application.
 * So with that we are able to see more clearly an application of the Adapter in a real scenario: it
 * allows the incompatible code that is inside the Core to be able to communicate with what is outside,
 * to do so the Adapter implements any abstraction that defined at the Ports and that the Usecases 
 * expects and then it is passed to this Usecases, after that any calls from the Usecases to the
 * used abstraction will then be sent directly to the Adapter that is actually implementing it.
 * In our example the Usecases calls methods to a database that the implementation is unknown for him,
 * what only matters is if it implements the abstraction that is used for that.
 */

namespace Adapter.After.Hexagonal
{
    public static class ClientHexagonal
    {
        public static void Run()
        {
            Console.WriteLine("== After - Hexagonal Example ==");

            var rest = new ClientRest();

            var newUsers = new List<Dictionary<string, string>>();

            for (int i = 0; i < 5; i++)
            {
                var user = new Dictionary<string, string>()
                {
                    { "name", $"User{i}" },
                    { "email", $"user{i}@test.com" },
                    { "password", $"password{i}" }
                };

                newUsers.Add(user);
            }
            newUsers.Add(new Dictionary<string, string>()
                {
                    { "name", $"User1" },
                    { "email", $"user1@test.com" },
                    { "password", $"password1" }
                }
            );

            newUsers.ForEach(u => PrintStatusCode(rest.Post(u)));

            PrintStatusCode(rest.Get());
        }

        private static void PrintStatusCode(int status)
        {
            Console.WriteLine($"Status Code: {status}");
        }
    }
}
