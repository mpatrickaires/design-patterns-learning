using Singleton.Enums;

namespace Singleton.After.Monostate.Models
{
    public class UserPreferences : IUserPreferences
    {
        private static Theme _theme = Theme.Light;
        private static int _fontSize = 12;

        public UserPreferences()
        {
        }

        public void SetTheme(Theme theme)
        {
            _theme = theme;
        }

        public Theme GetTheme()
        {
            return _theme;
        }

        public void SetFontSize(int fontSize)
        {
            _fontSize = fontSize;
        }

        public int GetFontSize()
        {
            return _fontSize;
        }

        public void GetPreferences()
        {
            Console.WriteLine($"Theme: {_theme}");
            Console.WriteLine($"Font Size: {_fontSize}");
        }
    }
}
