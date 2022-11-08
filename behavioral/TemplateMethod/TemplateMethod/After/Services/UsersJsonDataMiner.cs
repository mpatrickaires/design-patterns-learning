using System.Text;
using System.Text.Json;
using TemplateMethod.Common.Models;

namespace TemplateMethod.After.Services
{
    public class UsersJsonDataMiner : UserDataMinerTemplate
    {
        public UsersJsonDataMiner(string path) : base(path)
        {
        }

        protected override IEnumerable<User> ParseData(byte[] data) => JsonSerializer
            .Deserialize<IEnumerable<User>>(Encoding.UTF8.GetString(data), new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });

        protected override void PreExecution()
        {
            Console.WriteLine("Saving JSON file into database...\n");
        }

        protected override void PostExecution()
        {
            Console.WriteLine("Saving report into database...");
        }
    }
}
