using Singleton.After.Monostate.Models;
using Singleton.Before.Pages;
using Singleton.Enums;

void Separator()
{
    Console.WriteLine("\n-----------------------------------------------------------------------\n");
}

/*
 * With every new created page, a new instance of UserPreferences is createad with it own state,
 * which creates a situation where if the style is defined in one page it will be unique for only 
 * that page, not being replicated to the others, creating an inconsitency at a state that should be 
 * global (a user shouldn't need to set his preferred style at every single page).
 */

Console.WriteLine("== Without Singleton ==");

Singleton.Before.Pages.MainPage mainPageBefore = new Singleton.Before.Pages.MainPage();
mainPageBefore.UserPreferences.Theme = Theme.Dark;
mainPageBefore.UserPreferences.FontSize = 18;
Console.WriteLine($"--> Main Page Style <--");
mainPageBefore.LoadStyle();
Console.WriteLine();

Singleton.Before.Pages.FeedPage feedPageBefore = new Singleton.Before.Pages.FeedPage();
Console.WriteLine($"--> Feed Page Style <--");
feedPageBefore.LoadStyle();

Separator();

/*
 * Using Singleton, the state of UserPreferences is now global throughout all the the pages of the 
 * application, because the constructor is private (which makes sure that no code outside the class
 * can create a new instance) and the only method that provides a way of acessing this unique 
 * instance (GetInstance) always returns the already created instance, which shares the state
 * whenever its changed or used.
 * A problem with Singleton is that it's not possible to use an interface instead of a
 * concrete implementation due to the use of static methos. This can, however, be resolved with
 * the use of a different approach called Monostate.
 */

Console.WriteLine("== Using Singleton ==");

Singleton.After.Singleton.Pages.MainPage mainPageSingleton = new Singleton.After.Singleton.Pages.MainPage();
mainPageSingleton.UserPreferences.Theme = Theme.Dark;
mainPageSingleton.UserPreferences.FontSize = 18;
Console.WriteLine($"--> Main Page Style <--");
mainPageSingleton.LoadStyle();
Console.WriteLine();

Singleton.After.Singleton.Pages.FeedPage feedPageSingleton = new Singleton.After.Singleton.Pages.FeedPage();
Console.WriteLine($"--> Feed Page Style <--");
feedPageSingleton.LoadStyle();

Separator();

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

Console.WriteLine("== Using Monostate ==");

Singleton.After.Monostate.Pages.MainPage mainPageMonostate = new Singleton.After.Monostate.Pages.MainPage(new UserPreferences());
mainPageMonostate.UserPreferences.SetTheme(Theme.Dark);
mainPageMonostate.UserPreferences.SetFontSize(18);
Console.WriteLine($"--> Main Page Style <--");
mainPageMonostate.LoadStyle();
Console.WriteLine();

Singleton.After.Monostate.Pages.FeedPage feedPageMonostate = new Singleton.After.Monostate.Pages.FeedPage(new UserPreferences());
Console.WriteLine($"--> Feed Page Style <--");
feedPageMonostate.LoadStyle();
