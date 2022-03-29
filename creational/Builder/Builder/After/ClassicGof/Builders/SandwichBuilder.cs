using Builder.After.ClassicGof.Models;

namespace Builder.After.ClassicGof.Builders
{
    public class SandwichBuilder : ISandwichBuilder
    {
        private Sandwich _sandwich;

        public SandwichBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _sandwich = new Sandwich();
        }

        public Sandwich GetResult()
        {
            return _sandwich;
        }

        public void SetBreadType(string breadType)
        {
            _sandwich.BreadType = breadType;
        }

        public void SetCheese(string cheese)
        {
            _sandwich.Cheese = cheese;
        }

        public void SetMainFilling(string mainFilling)
        {
            _sandwich.MainFilling = mainFilling;
        }

        public void SetVegetables(List<string> vegetables)
        {
            _sandwich.Vegetables = vegetables;
        }

        public void SetSauce(string sauce)
        {
            _sandwich.Sauce = sauce;
        }
    }
}
