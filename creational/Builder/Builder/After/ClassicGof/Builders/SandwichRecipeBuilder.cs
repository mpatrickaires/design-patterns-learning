using Builder.After.ClassicGof.Models;

namespace Builder.After.ClassicGof.Builders
{
    public class SandwichRecipeBuilder : ISandwichBuilder
    {
        private SandwichRecipe _sandwichRecipe;

        public SandwichRecipeBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _sandwichRecipe = new SandwichRecipe();
        }

        public SandwichRecipe GetResult()
        {
            return _sandwichRecipe;
        }

        public void SetBreadType(string breadType)
        {
            _sandwichRecipe.BreadType = breadType;
        }

        public void SetCheese(string cheese)
        {
            _sandwichRecipe.Cheese = cheese;
        }

        public void SetMainFilling(string mainFilling)
        {
            _sandwichRecipe.MainFilling = mainFilling;
        }

        public void SetVegetables(List<string> vegetables)
        {
            _sandwichRecipe.Vegetables = vegetables;
        }

        public void SetSauce(string sauce)
        {
            _sandwichRecipe.Sauce = sauce;
        }
    }
}
