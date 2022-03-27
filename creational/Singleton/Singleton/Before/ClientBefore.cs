using Singleton.Before.Pages;
using Singleton.Enums;

/*
* With every new created page, a new instance of UserPreferences is createad with it own state,
* which creates a situation where if the style is defined in one page it will be unique for 
* only that page, not being replicated to the others, creating an inconsitency at a state that 
* should be global (a user shouldn't need to set his preferred style at every single page).
*/

namespace Singleton.Before
{

    public static class ClientBefore
    {
        public static void Run()
        {
            Console.WriteLine("== Without Singleton ==");

            MainPage mainPage = new MainPage();
            mainPage.UserPreferences.Theme = Theme.Dark;
            mainPage.UserPreferences.FontSize = 18;
            Console.WriteLine($"--> Main Page Style <--");
            mainPage.LoadStyle();
            Console.WriteLine();

            FeedPage feedPageBefore = new FeedPage();
            Console.WriteLine($"--> Feed Page Style <--");
            feedPageBefore.LoadStyle();
        }
    }
}
