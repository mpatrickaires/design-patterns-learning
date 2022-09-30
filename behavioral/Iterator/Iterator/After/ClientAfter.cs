using Iterator.After.IterableCollections;
using Iterator.After.Iterators.Interfaces;

namespace Iterator.After
{
    public static class ClientAfter
    {
        public static void Run()
        {
            var usersCsvCollection = new UsersCsvCollection("./Data/users.csv");
            var usersCsvIterator = usersCsvCollection.CreateIterator();
            PrintUsers(usersCsvIterator);
        }

        private static void PrintUsers(IUsersIterator usersIterator)
        {
            while (!usersIterator.IsDone())
            {
                Console.WriteLine(usersIterator.Current());
                usersIterator.Next();
            }
        }
    }
}
