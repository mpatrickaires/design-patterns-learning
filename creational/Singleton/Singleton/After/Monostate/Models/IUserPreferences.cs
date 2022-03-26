using Singleton.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.After.Monostate.Models
{
    public interface IUserPreferences
    {
        public void SetTheme(Theme theme);
        public Theme GetTheme();
        public void SetFontSize(int fontSize);
        public int GetFontSize();
        public void GetPreferences();
    }
}
