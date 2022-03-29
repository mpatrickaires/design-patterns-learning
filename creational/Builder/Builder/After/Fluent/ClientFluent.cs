using Builder.After.Fluent.Builders;

/*
 * Here we have a more modern implementation of the builder, it is named FluentBuilder because the way 
 * the builder constructs the object is almost like reading a phrase, while also being made all in one
 * line, which greatly increases readability.
 * To achieve this, at each step of the building, the builder class must return itself, so the methods
 * can be chained one after another in one line. In the end, when the resulting object is ready,
 * just call the method to return what was built (in this case, the method "Build").
 * 
 * In this example, to make things simplier, we didn't make use of the SandwichDirecotr nor the 
 * SandwichRecipe, but both could be used again with the chained method calling being used by the 
 * director.
 */

namespace Builder.After.Fluent
{
    public static class ClientFluent
    {
        public static void Run()
        {
            Console.WriteLine("== After - Fluent ==");

            var sandwichBuilder = new SandwichBuilder();

            var naturalSandwich = sandwichBuilder
                .BreadType("Whole Weath")
                .MainFilling("Chicken")
                .Cheese("Parmesan")
                .AddVegetable("Tomato")
                .AddVegetable("Lettuce")
                .Build();

            // Since the builded sandwich is kept as an attribute in the instance of sandwichBuilder, we
            // can reuse it whenever we want without having to create the same variation again.
            var anotherNaturalSandwich = sandwichBuilder
                .Build();

            sandwichBuilder.Reset();

            var homemadeSandwich = sandwichBuilder
                .BreadType("Plain")
                .MainFilling("Beef")
                .Sauce("Ketchup")
                .Build();

            Console.WriteLine("--> Natural Sandwich <--");
            naturalSandwich.Details();
            Console.WriteLine();

            Console.WriteLine("--> Another Natural Sandwich <--");
            anotherNaturalSandwich.Details();
            Console.WriteLine();

            Console.WriteLine("--> Homemade Sandwich <--");
            homemadeSandwich.Details();
        }
    }
}
