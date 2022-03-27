using Singleton.After.Monostate.Models;

namespace Singleton.After.Monostate.Pages
{
    public class MainPage : Page
    {
        public MainPage(IUserPreferences userPreferences) : base(userPreferences)
        {
        }
    }
}
