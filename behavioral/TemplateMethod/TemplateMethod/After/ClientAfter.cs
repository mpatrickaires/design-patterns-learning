using TemplateMethod.After.Services;

/*
 * Now, this is our new code. Basically, by following the template method pattern, we created an abstract class that contains all of the repeated
 * code we had in our another example, such as obtaining the raw data and creating the report, whilst the routines that have variation (the
 * transformation of the raw data into a collection of 'User') is made abstract. So, it works the following way: the base class will contains
 * the implementation of invariant routines (which are the repeated code between classes) and also the implementation of the template method, which
 * is basically the central method that will call the invariant and variant routines; about the variant routines, they are abstract in the base
 * class and must be implemented by the subclasses; finally, the base class can also contain some optional methods, that are basically hooks for
 * the template method (in our example, there is two optional methods: one that is called before the exectuion and another that is called after
 * the execution).
 * With that in mind, as we can see from the example, the 'UsersCsvDataMiner' inherits from the base 'UserDataMinerTemplate', implemented the 
 * required method, which is the 'ParseData' (for transforming the raw data into the collection of users), and also the hook that is called after
 * the execution of the routine ('PostExecution'). As for the 'UsersJsonDataMiner', it did basically the same as the 'UsersCsvDataMiner', but
 * it also implemented the optional method of 'PreExecution', which is the hook for before the execution of the routine.
 * 
 * So, that's that! The template method allowed us to easily stop with the repeating code, making the code more readable and whilst increasing its 
 * maintainability.
 */

namespace TemplateMethod.After
{
    public static class ClientAfter
    {
        public static void Run()
        {
            Console.WriteLine("===> After <===");

            Console.WriteLine("(CSV)");
            var usersCsvDataMiner = new UsersCsvDataMiner("./Common/Data/users.csv");
            usersCsvDataMiner.GenerateReport();

            Console.WriteLine("\n===\n");

            Console.WriteLine("(JSON)");
            var usersJsonDataMiner = new UsersJsonDataMiner("./Common/Data/users.json");
            usersJsonDataMiner.GenerateReport();
        }
    }
}
