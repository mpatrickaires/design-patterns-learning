using Singleton.After.Monostate.Models;

namespace Singleton.After.Monostate.Pages
{
    public abstract class Page
    {
        public IUserPreferences UserPreferences { get; set; }

        public Page(IUserPreferences userPreferences)
        {
            // Every page needs the UserPreferences to load the style based on it
            UserPreferences = userPreferences;
        }

        public void LoadStyle()
        {
            UserPreferences.GetPreferences();
        }
    }
}
