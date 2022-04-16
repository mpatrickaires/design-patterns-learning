namespace Bridge.Before.Models.Platforms
{
    public class Windows
    {
        public void Button()
        {
            Console.WriteLine("Windows Button");
        }

        public void Input()
        {
            Console.WriteLine("Windows Input");
        }

        public void Notification(string message)
        {
            Console.WriteLine($"Windows Notification: {message}");
        }
    }
}
