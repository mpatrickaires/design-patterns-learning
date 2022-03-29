using Builder.After.Fluent.Models;

namespace Builder.After.Fluent.Builders
{
    public class SandwichBuilder
    {
        private Sandwich _sandwich;

        public SandwichBuilder()
        {
            Reset();
        }
        public SandwichBuilder Reset()
        {
            _sandwich = new Sandwich();
            return this;
        }

        public Sandwich Build()
        {
            return _sandwich;
        }

        public SandwichBuilder BreadType(string breadType)
        {
            _sandwich.BreadType = breadType;
            return this;
        }

        public SandwichBuilder Cheese(string cheese)
        {
            _sandwich.Cheese = cheese;
            return this;
        }

        public SandwichBuilder MainFilling(string mainFilling)
        {
            _sandwich.MainFilling = mainFilling;
            return this;
        }

        public SandwichBuilder AddVegetable(string vegetables)
        {
            _sandwich.Vegetables.Add(vegetables);
            return this;
        }

        public SandwichBuilder Sauce(string sauce)
        {
            _sandwich.Sauce = sauce;
            return this;
        }
    }
}
