using Bridge.After.Models.Platforms.Interfaces;

namespace Bridge.After.Models.Platforms
{
    public class Windows : IPlatform
    {
        public void DisplayButton()
        {
            Console.WriteLine("Windows Button");
        }

        public void DisplayInput()
        {
            Console.WriteLine("Windows Input");
        }

        public void DisplayNotification(string message)
        {
            Console.WriteLine($"Windows Notification: {message}");
        }
    }
}
