using Iterator.After.IterableCollections;
using Iterator.After.Iterators.Interfaces;

/*
 * Now, let's take a look at that!
 * We represented our datasets as their own collection objects, and since they gather data from 
 * datasets in different formats, the logic of going through them is different. But there's one more 
 * thing that will change everything: those classes implements an interface that returns an Iterator!
 * "What is an Iterator?", you shall ask. Well, an Iterator is by itself an object that knows exactly
 * how to go through a specific collection (it is highly coupled to the concrete class of the 
 * collection) while exposing simple methods to retrieve the job done (through a commom interface).
 * This is basically how our example was changed. 
 * Take a look at the following code, the "Run" method serves as a bootstrap to instantiate our 
 * collections and iterators; we also have the "PrintUsers" method, which simply requires the 
 * interface of the iterators and with that it is able to retrieve the users simply by using the 
 * exposed methods of the interface, without the need of knowing how to go through the collections 
 * that contains those records!
 * So, we were able to create a code where the client can be worried just with going through a 
 * collection by using the iterator, no matter the nature of that collection. Oh, and another cool 
 * thing is that iterators are (generally) independent from each other referring to collection 
 * position so we can have multiple iterators being in different positions of the same collection.
 */

namespace Iterator.After
{
    public static class ClientAfter
    {
        public static async Task Run()
        {
            Console.WriteLine("== After ==");
            var usersCsvCollection = new UsersCsvCollection("./Data/users.csv");
            var usersCsvIterator = usersCsvCollection.CreateIterator();

            await using var usersExcelCollection = new UsersExcelCollection("./Data/users.xlsx");
            var usersExcelIterator = usersExcelCollection.CreateIterator();

            Console.WriteLine("--> Reading from CSV:");
            PrintUsers(usersCsvIterator);
            Console.WriteLine("\n--> Reading from Excel:");
            PrintUsers(usersExcelIterator);
        }

        private static void PrintUsers(IUsersIterator usersIterator)
        {
            while (usersIterator.HasMore())
            {
                Console.WriteLine(usersIterator.Current());
                usersIterator.Next();
            }
        }
    }
}
