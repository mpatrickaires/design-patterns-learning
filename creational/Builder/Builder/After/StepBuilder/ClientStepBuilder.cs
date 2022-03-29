using Builder.After.StepBuilder.Builders;

/*
 * We might have an object where some sequential steps need to be followed or even some attributes 
 * are obligatory and must be used to create an object that is really complete and without errors.
 * But, when using the others builders presented to create an object like the described, we don't have
 * a way to guide the user through those steps and neither a clear way to do that, which can create
 * problems by giving an object that is incomplete or even wrong.
 * Take the Sandwich for example, using the others builders the client has total freedom to create
 * a Sandwich object that doesn't have a bread type defined, which should be obligatory and could
 * cause erros due to not having a value; or we could even have some logic in the building steps, 
 * like if the Sandwich is made with fish instead of meat, it can't have cheese.
 * So, to achieve that, we can use the StepBuilder, which is a new approach to the Builder that creates
 * a more rigorous building routine, returning the resulting object only when all the previous steps
 * are fulfilled. The StepBuilder allows us to define the sequential steps that must be followed,
 * specifying which one are obligatories and also what are some values that can't coexist (like in our
 * example, the fish and the cheese).
 */

namespace Builder.After.StepBuilder
{
    public static class ClientStepBuilder
    {
        public static void Run()
        {
            Console.WriteLine("== After - StepBuilder ==");

            var fluentBuilder = new Builder.After.Fluent.Builders.SandwichBuilder();
            // Here, with the FluentBuilder, we can allow the user to create a Sandwich that only have
            // cheese, which by logic couldn't happen but the FluentBuilder gives the freedom to do so.
            var wrongSandwich = fluentBuilder
                .Cheese("Cheedar")
                .Build();

            // Now, with the StepBuilder, we only give the final result (the object of Sandwich) if
            // all the steps we required are fulfilled, even if the don't receive a value.
            var naturalSandwich = SandwichBuilder.NewBuilder()
                .BreadType("Whole Weath")
                .Meat("Chicken")
                .WithCheese("Parmesan")
                .AddVegetable("Tomato")
                .AddVegetable("Lettuce")
                .NoMoreVegetables()
                .NoSauce()
                .Build();

            var homemadeSandwich = SandwichBuilder.NewBuilder()
                .BreadType("Plain")
                .Meat("Beef")
                .NoCheese()
                .NoVegetables()
                .WithSauce("Ketchup")
                .Build();

            // Here we can see the mentioned business logic being applied by the builder: due to the
            // Sandwich be made with fish, it can't have cheese. This is forced by a compile time error
            // that is thrown during the development of the code, preventing it for even reaching the
            // execution part
            var fishSandwich = SandwichBuilder.NewBuilder()
                .BreadType("Baguette")
                .Fish("Tuna")
                // .WithCheese("Gorgonzola") -- This would give a compile time error
                .AddVegetable("Lettuce")
                .NoMoreVegetables()
                .NoSauce()
                .Build();

            Console.WriteLine("--> Natural Sandwich <--");
            naturalSandwich.Details();
            Console.WriteLine();

            Console.WriteLine("--> Homemade Sandwich <--");
            homemadeSandwich.Details();
            Console.WriteLine();

            Console.WriteLine("--> Fish Sandwich <--");
            fishSandwich.Details();
            Console.WriteLine();

        }
    }
}
