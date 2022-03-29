using Builder.After.StepBuilder.Models;

namespace Builder.After.StepBuilder.Builders
{
    public class SandwichBuilder
    {
        private SandwichBuilder()
        {
        }

        public static BreadTypeStep NewBuilder()
        {
            return new Steps();
        }

        public interface BreadTypeStep
        {
            MainFillingStep BreadType(string breadType);
        }

        public interface MainFillingStep
        {
            CheeseStep Meat(string meat);
            VegetableStep Fish(string fish);
        }

        public interface CheeseStep
        {
            VegetableStep WithCheese(string cheese);
            VegetableStep NoCheese();
        }

        public interface VegetableStep
        {
            VegetableStep AddVegetable(string vegetable);
            SauceStep NoMoreVegetables();
            SauceStep NoVegetables();
        }

        public interface SauceStep
        {
            BuildStep NoSauce();
            BuildStep WithSauce(string sauce);
        }

        public interface BuildStep
        {
            Sandwich Build();
        }

        private class Steps : BreadTypeStep, MainFillingStep, CheeseStep, VegetableStep, SauceStep, BuildStep
        {
            private string _breadType;
            private string _meat;
            private string _fish;
            private string _cheese;
            private List<string> _vegetable = new List<string>();
            private string _sauce;

            public MainFillingStep BreadType(string breadType)
            {
                _breadType = breadType;
                return this;
            }

            public CheeseStep Meat(string meat)
            {
                _meat = meat;
                return this;
            }

            public VegetableStep Fish(string fish)
            {
                _fish = fish;
                return this;
            }

            public VegetableStep WithCheese(string cheese)
            {
                _cheese = cheese;
                return this;
            }

            public VegetableStep NoCheese()
            {
                return this;
            }

            public VegetableStep AddVegetable(string vegetable)
            {
                _vegetable.Add(vegetable);
                return this;
            }

            public SauceStep NoMoreVegetables()
            {
                return this;
            }

            public SauceStep NoVegetables()
            {
                return this;
            }

            public BuildStep WithSauce(string sauce)
            {
                _sauce = sauce;
                return this;
            }

            public BuildStep NoSauce()
            {
                return this;
            }

            public Sandwich Build()
            {
                var sandwich = new Sandwich();

                sandwich.BreadType = _breadType;

                if (!string.IsNullOrEmpty(_meat))
                {
                    sandwich.Meat = _meat;
                }
                else
                {
                    sandwich.Fish = _fish;
                }

                if (!string.IsNullOrEmpty(_cheese))
                {
                    sandwich.Cheese = _cheese;
                }

                _vegetable.ForEach(v => sandwich.Vegetables.Add(v));

                if (!string.IsNullOrEmpty(_sauce))
                {
                    sandwich.Sauce = _sauce;
                }

                return sandwich;
            }
        }
    }
}
