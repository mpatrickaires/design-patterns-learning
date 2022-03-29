using System.Text;

namespace Builder.After.StepBuilder.Models
{
    public class Sandwich
    {
        public string? BreadType { get; set; }
        public string? Meat { get; set; }
        public string? Fish { get; set; }
        public string? Cheese { get; set; }
        public List<string> Vegetables { get; set; } = new List<string>();
        public string? Sauce { get; set; }
        public void Details()
        {
            Console.WriteLine($"Bread Type: {BreadType}");
            Console.WriteLine($"Meat: {Meat}");
            Console.WriteLine($"Fish: {Fish}");
            Console.WriteLine($"Cheese: {Cheese}");

            var stringBuilder = new StringBuilder();
            Vegetables?.ForEach(v => stringBuilder.AppendLine($"\t- {v}"));

            Console.WriteLine($"Vegetables:");
            Console.Write(stringBuilder.ToString());

            Console.WriteLine($"Sauce: {Sauce}");
        }
    }
}
