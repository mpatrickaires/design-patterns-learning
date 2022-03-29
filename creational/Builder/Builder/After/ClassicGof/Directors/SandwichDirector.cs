using Builder.After.ClassicGof.Builders;

namespace Builder.After.ClassicGof.Directors
{
    public class SandwichDirector
    {
        public void MakeNaturalSandwich(ISandwichBuilder sandwichBuilder)
        {
            sandwichBuilder.Reset();
            sandwichBuilder.SetBreadType("Whole Weath");
            sandwichBuilder.SetMainFilling("Chicken");
            sandwichBuilder.SetCheese("Parmesan");
            sandwichBuilder.SetVegetables(new List<string> { "Tomato", "Lettuce" });
        }

        public void MakeHomemadeSandwich(ISandwichBuilder sandwichBuilder)
        {
            sandwichBuilder.Reset();
            sandwichBuilder.SetBreadType("Plain");
            sandwichBuilder.SetMainFilling("Beef");
            sandwichBuilder.SetSauce("Ketchup");

        }
    }
}
