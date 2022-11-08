using System.Text;
using System.Text.Json;
using TemplateMethod.Common.Models;

namespace TemplateMethod.Before.Services
{
    public class UsersJsonDataMiner
    {
        private readonly string _path;

        public UsersJsonDataMiner(string path)
        {
            _path = path;
        }

        public void GenerateReport()
        {
            Console.WriteLine($"Saving JSON file into database...\n");
            var rawData = GetRawData();
            var data = ParseData(rawData);
            var report = GetReport(data);
            PrintReport(report);
            Console.WriteLine("Saving report into database...");
        }

        private byte[] GetRawData() => File.ReadAllBytes(_path);

        private IEnumerable<User> ParseData(byte[] data) => JsonSerializer
            .Deserialize<IEnumerable<User>>(Encoding.UTF8.GetString(data), new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });

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
