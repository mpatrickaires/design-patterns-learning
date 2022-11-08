using System.Text;
using TemplateMethod.Common.Models;

namespace TemplateMethod.After.Services
{
    public abstract class UserDataMinerTemplate
    {
        private readonly string _path;

        protected UserDataMinerTemplate(string path)
        {
            _path = path;
        }

        public void GenerateReport()
        {
            PreExecution();
            var rawData = GetRawData();
            var data = ParseData(rawData);
            var report = GetReport(data);
            PrintReport(report);
            PostExecution();
        }

        protected virtual void PreExecution() { }

        protected virtual void PostExecution() { }

        protected byte[] GetRawData() => File.ReadAllBytes(_path);

        protected abstract IEnumerable<User> ParseData(byte[] data);

        protected string GetReport(IEnumerable<User> data)
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

        protected void PrintReport(string report) => Console.WriteLine(report);
    }
}
