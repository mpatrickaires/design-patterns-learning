using System.Text;
using TemplateMethod.Common.Enums;
using TemplateMethod.Common.Models;

namespace TemplateMethod.After.Services
{
    public class UsersCsvDataMiner : UserDataMinerTemplate
    {
        public UsersCsvDataMiner(string path) : base(path)
        {
        }

        protected override IEnumerable<User> ParseData(byte[] data)
        {
            var users = new List<User>();
            var lines = Encoding.UTF8.GetString(data).Split("\r\n");

            foreach (var line in lines)
            {
                var fields = line.Split(";");

                Enum.TryParse(fields[2].Replace(" ", ""), out Country country);

                users.Add(new User
                {
                    Name = fields[0],
                    Email = fields[1],
                    Country = country,
                    Premium = bool.Parse(fields[3]),
                });
            }

            return users;
        }

        protected override void PostExecution()
        {
            Console.WriteLine("Saving report into database...");
        }
    }
}
