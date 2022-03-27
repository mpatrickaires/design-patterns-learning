using Singleton.After.Monostate.Models;
using Singleton.After.Monostate.Pages;
using Singleton.Enums;

/*
 * Now, with Monostate, we still have a global state of UserPreferences (due to the attributes of 
 * theme and font size being static) while counting with the advantage of the Page using only an
 * interface and not a concrete class.
 * The only disavantage of Monostate comparing to the Singleton is that it remains unclear for the
 * programmer that all instances of UserPreferences will be sharing a global state without seeing
 * the internal code of the class, this happens because the use of 'new' keyword creates a sense
 * that a new instance with it own state is created always it is called, as opposed to Singleton
 * 'GetInstance' method.
 * 
 * Obs: The following code surely could be better by creating only a single instance of 
 * UserPreferences in a variable to be injected at each page constructor, remaining a shared state 
 * of the instance, but it was made creating a new instace for each page only for exemplification 
 * and to show how, by doing that way, the Monostate still assures that the state is 
 * global throughout all the new instances.
 */

namespace Singleton.After.Monostate
{
    public static class ClientMonostate
    {
        public static void Run()
        {
            Console.WriteLine("== Using Monostate ==");

            MainPage mainPageMonostate = new MainPage(new UserPreferences());
            mainPageMonostate.UserPreferences.SetTheme(Theme.Dark);
            mainPageMonostate.UserPreferences.SetFontSize(18);
            Console.WriteLine($"--> Main Page Style <--");
            mainPageMonostate.LoadStyle();
            Console.WriteLine();

            FeedPage feedPageMonostate = new FeedPage(new UserPreferences());
            Console.WriteLine($"--> Feed Page Style <--");
            feedPageMonostate.LoadStyle();
        }
    }
}
