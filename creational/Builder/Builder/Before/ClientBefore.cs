using Builder.Before.Models;

/*
 * Sandwich is a complex class due to the number of attributes it can receive, which can create a
 * huge variety of object representations of that class.
 * Therefore, to be able to support all those representations, the class needs to have a big number
 * of constructors to be able to accept different attributes. Beside creating a huge mess in the code 
 * with so many constructors, if the Client wants a Sandwich that has sauce but no cheese or 
 * vegetables, it is necessary to give a null argument to the constructor, which creates an ugly code.
 * 
 * You could, of course, create variations of the constructor (like one that only needs BreadType, 
 * MainFilling and Sauce), but this would only increase the already huge number of constructors and 
 * would create an even bigger mess (what if a new attribute is added?); also, you can't take full 
 * advantage of overloaded constructors, since many of the parameters are of the same type (string).
 */

namespace Builder.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            Console.WriteLine("== Before ==");

            Sandwich normalSandwich = new Sandwich("Plain", "Beef");
            Console.WriteLine("--> Normal Sandwich <--");
            normalSandwich.Details();
            Console.WriteLine();

            Sandwich naturalSandwich = new Sandwich("Whole Weath", "Chicken", "Parmesan", new List<string> { "Tomato", "Lettuce" });
            Console.WriteLine("--> Natural Sandwich <--");
            naturalSandwich.Details();
            Console.WriteLine();

            Sandwich homemadeSandwich = new Sandwich("Plain", "Beef", null, null, "Ketchup");
            Console.WriteLine("--> Homemade Sandwich <--");
            homemadeSandwich.Details();
            Console.WriteLine();
        }
    }
}
