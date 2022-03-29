using Builder.After.ClassicGof.Builders;
using Builder.After.ClassicGof.Directors;

/*
 * Using the Builder pattern following the classic implementation of GOF, we now have delegated all
 * the reponsability of creating the object and setting the attributes to a builder class outside the
 * Sandwich class. There is a builder to create a delicious sandwich (SandwichBuilder building a 
 * Sandwich) and also a builder to create a descriptive recipe on how to make a sandwich 
 * (SandwichRecipeBuilder building a SandwichRecipe). 
 * We also have the use of the Director, whose use in the code is optional. His job is knowing how to 
 * create the object based in what was asked by the client, and he does that by calling the 
 * corresponding methods of the builder and passing the arguments that in the end will return the asked 
 * object variation.
 * An interesting approach used here was to use the SandwichDirector to be able to call the same routine
 * to create a Sandwich and a SandwichRecipe, considering that both implements the same interface that
 * the SandwichDirector uses to manipulate the builder (ISandwichBuilder). To achieve that, the  
 * resulted object will need to be returned by the concrete implementation of the ISandwichBuilder,
 * after the SandwichDirector used it, because each builder returns a differente type. If only the
 * class/abstraction of Sandwich was used in the code, so the SandwichDirector could also do the job 
 * of returning it.
 */

namespace Builder.After.ClassicGof
{
    public static class ClientClassicGof
    {
        public static void Run()
        {
            Console.WriteLine("== After - Classic GOF ==");

            var sandwichDirector = new SandwichDirector();
            var sandwichBuilder = new SandwichBuilder();
            var sandwichRecipeBuilder = new SandwichRecipeBuilder();

            sandwichDirector.MakeNaturalSandwich(sandwichBuilder);
            var naturalSandwich = sandwichBuilder.GetResult();

            Console.WriteLine("--> Natural Sandwich <--");
            naturalSandwich.Details();
            Console.WriteLine();

            sandwichDirector.MakeNaturalSandwich(sandwichRecipeBuilder);
            var naturalSandwichRecipe = sandwichRecipeBuilder.GetResult();

            Console.WriteLine("--> Natural Sandwich Recipe <--");
            naturalSandwichRecipe.Details();
            Console.WriteLine();

            // We can also use the Builder without the Director, thus why he is optional.
            Console.WriteLine("--> Natural Sandwich without using the Director <--");
            sandwichBuilder.Reset();
            sandwichBuilder.SetBreadType("Whole Weath");
            sandwichBuilder.SetMainFilling("Chicken");
            sandwichBuilder.SetCheese("Parmesan");
            sandwichBuilder.SetVegetables(new List<string> { "Tomato", "Lettuce" });
            var homemadeSandwich = sandwichBuilder.GetResult();
            homemadeSandwich.Details();
        }
    }
}
