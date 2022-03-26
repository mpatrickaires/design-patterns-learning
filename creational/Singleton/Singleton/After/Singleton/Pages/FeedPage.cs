using Singleton.After.Singleton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.After.Singleton.Pages
{
    public class FeedPage : Page
    {
        public FeedPage() : base(UserPreferences.GetInstance())
        {
        }
    }
}
