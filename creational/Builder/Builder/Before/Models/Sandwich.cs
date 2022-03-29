using System.Text;

namespace Builder.Before.Models
{
    public class Sandwich
    {
        public string? BreadType { get; set; }
        public string? MainFilling { get; set; }
        public string? Cheese { get; set; }
        public List<string>? Vegetables { get; set; }
        public string? Sauce { get; set; }

        public Sandwich(string breadType, string mainFilling)
        {
            BreadType = breadType;
            MainFilling = mainFilling;
        }

        public Sandwich(string breadType, string mainFilling, string cheese)
        {
            BreadType = breadType;
            MainFilling = mainFilling;
            Cheese = cheese;
        }

        public Sandwich(string breadType, string mainFilling, string cheese, List<string> vegetables)
        {
            BreadType = breadType;
            MainFilling = mainFilling;
            Cheese = cheese;
            Vegetables = vegetables;
        }

        public Sandwich(string breadType, string mainFilling, string cheese, List<string> vegetables, string sauce)
        {
            BreadType = breadType;
            MainFilling = mainFilling;
            Cheese = cheese;
            Vegetables = vegetables;
            Sauce = sauce;
        }

        public void Details()
        {
            Console.WriteLine($"Bread Type: {BreadType}");
            Console.WriteLine($"Main Filling: {MainFilling}");
            Console.WriteLine($"Cheese: {Cheese}");

            var stringBuilder = new StringBuilder();
            Vegetables?.ForEach(v => stringBuilder.AppendLine($"\t- {v}"));

            Console.WriteLine($"Vegetables:");
            Console.Write(stringBuilder.ToString());

            Console.WriteLine($"Sauce: {Sauce}");
        }
    }
}
