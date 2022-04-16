namespace Bridge.Before.Models.Platforms
{
    public class Linux
    {
        public void DisplayButton()
        {
            Console.WriteLine("Linux Button");
        }

        public void DisplayInput()
        {
            Console.WriteLine("Linux Input");
        }

        public void DisplayNotification(string message)
        {
            Console.WriteLine($"Linux Notification: {message}");
        }
    }
}
