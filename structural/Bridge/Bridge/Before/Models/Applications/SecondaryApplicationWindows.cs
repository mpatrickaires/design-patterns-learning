using Bridge.Before.Models.Platforms;

namespace Bridge.Before.Models.Applications
{
    public class SecondaryApplicationWindows : Application
    {
        private readonly Windows _windows = new Windows();
        protected override void Render()
        {
            Console.WriteLine("Rendering Secondary Application");
            _windows.Button();
            _windows.Button();
        }

        protected override void Notify(string message)
        {
            _windows.Notification($"[Secondary Application] {message}");
        }
    }
}
