using Adapter.After.Hexagonal.Core.Models;
using Adapter.After.Hexagonal.Core.Usecases;
using Adapter.After.Hexagonal.Infrastructure;

namespace Adapter.After.Hexagonal.Application
{
    public class ClientRest
    {
        private UserService userService = new UserService(new UserMemoryDatabaseAdapter());

        public int Post(Dictionary<string, string> values)
        {
            try
            {
                var user = new User(values["name"], values["email"], values["password"]);
                userService.SaveUser(user);
                return 201;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 400;
            }
        }

        public int Get()
        {
            var users = userService.GetUsers().ToList();
            users.ForEach(Console.WriteLine);

            return 200;
        }
    }
}
