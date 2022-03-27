using Singleton.After.Monostate.Models;

namespace Singleton.After.Monostate.Pages
{
    public class FeedPage : Page
    {
        public FeedPage(IUserPreferences userPreferences) : base(userPreferences)
        {
        }
    }
}
