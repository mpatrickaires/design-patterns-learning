using System.Text;

namespace Builder.After.ClassicGof.Models
{
    public class SandwichRecipe
    {
        public string? BreadType { get; set; }
        public string? MainFilling { get; set; }
        public string? Cheese { get; set; }
        public List<string>? Vegetables { get; set; }
        public string? Sauce { get; set; }
        public void Details()
        {
            Console.WriteLine($"\t* Use two slices of {BreadType} bread.");
            Console.WriteLine($"\t* Cut the {MainFilling} and place in the bread.");

            if (!string.IsNullOrEmpty(Cheese))
                Console.WriteLine($"\t* Take some slices of {Cheese} cheese and put on top of the {MainFilling}.");

            var stringBuilder = new StringBuilder();

            if (Vegetables != null && Vegetables.Count > 0)
            {
                var length = Vegetables.Count - 1;
                for (int i = 0; i <= length; i++)
                {
                    stringBuilder.Append(i == length ? Vegetables[i] : $"{Vegetables[i]}, ");
                }

                Console.WriteLine($"\t* For the vegetables, use the following: {stringBuilder}.");
            }

            if (!string.IsNullOrEmpty(Sauce))
                Console.WriteLine($"\t* Pour over some {Sauce}.");

            Console.WriteLine("\t* That's all, your delicious sandwich is ready!");
        }
    }
}
