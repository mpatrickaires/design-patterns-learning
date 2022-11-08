using System.Text;
using TemplateMethod.Common.Enums;
using TemplateMethod.Common.Models;

namespace TemplateMethod.Before.Services
{
    public class UsersCsvDataMiner
    {
        private readonly string _path;

        public UsersCsvDataMiner(string path)
        {
            _path = path;
        }

        public void GenerateReport()
        {
            var rawData = GetRawData();
            var data = ParseData(rawData);
            var report = GetReport(data);
            PrintReport(report);
            Console.WriteLine("Saving report into database...");
        }

        private byte[] GetRawData() => File.ReadAllBytes(_path);

        private IEnumerable<User> ParseData(byte[] data)
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

        private string GetReport(IEnumerable<User> data)
        {
            var report = new StringBuilder();

            var usersPerCountry = data.GroupBy(d => d.Country);

            report.AppendLine("--> Quantity of Users Per Country <--");
            foreach (var grouping in usersPerCountry)
            {
                var country = grouping.Key;
                var quantity = grouping.Count();

                report.AppendLine($"{country} - {quantity}");
            }

            report.AppendLine();

            report.AppendLine("--> Quantity of Premium Users Per Country <--");
            foreach (var grouping in usersPerCountry)
            {
                var country = grouping.Key;
                var quantity = grouping.Count(g => g.Premium);

                report.AppendLine($"{country} - {quantity}");
            }

            return report.ToString();
        }

        private void PrintReport(string report) => Console.WriteLine(report);
    }
}
