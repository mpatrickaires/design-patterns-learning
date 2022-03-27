using Singleton.After.Singleton.Models;

namespace Singleton.After.Singleton.Pages
{
    public abstract class Page
    {
        public UserPreferences UserPreferences { get; set; }

        public Page(UserPreferences userPreferences)
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
