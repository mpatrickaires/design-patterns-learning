using System.Text;

namespace Builder.After.ClassicGof.Models
{
    public class Sandwich
    {
        public string? BreadType { get; set; }
        public string? MainFilling { get; set; }
        public string? Cheese { get; set; }
        public List<string>? Vegetables { get; set; }
        public string? Sauce { get; set; }
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
