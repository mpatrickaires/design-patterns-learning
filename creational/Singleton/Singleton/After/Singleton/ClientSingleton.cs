using Singleton.After.Singleton.Pages;
using Singleton.Enums;

/*
 * Using Singleton, the state of UserPreferences is now global throughout all the the pages of the 
 * application, because the constructor is private (which makes sure that no code outside the class
 * can create a new instance) and the only method that provides a way of acessing this unique 
 * instance (GetInstance) always returns the already created instance, which shares the state
 * whenever its changed or used.
 * A problem with Singleton is that it's not possible to use an interface instead of a
 * concrete implementation due to the use of static methods. This can, however, be resolved with
 * the use of a different approach called Monostate.
 */

namespace Singleton.After.Singleton
{
    public static class ClientSingleton
    {
        public static void Run()
        {
            Console.WriteLine("== Using Singleton ==");

            MainPage mainPageSingleton = new MainPage();
            mainPageSingleton.UserPreferences.Theme = Theme.Dark;
            mainPageSingleton.UserPreferences.FontSize = 18;
            Console.WriteLine($"--> Main Page Style <--");
            mainPageSingleton.LoadStyle();
            Console.WriteLine();

            FeedPage feedPageSingleton = new FeedPage();
            Console.WriteLine($"--> Feed Page Style <--");
            feedPageSingleton.LoadStyle();
        }
    }
}
